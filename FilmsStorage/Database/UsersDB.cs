using FilmsStorage.Models;
using FilmsStorage.Settings;
using System.Data.SqlClient;

namespace FilmsStorage.Database
{
    public class UsersDB
    {
        public static User? Authorization(string login, string password)
        {
            User user;

            string sqlExpr = "SELECT Id, Name, IsAdmin FROM Users WHERE Login = @login AND Password = @password";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);
                cmd.Parameters.Add(new SqlParameter("@login", login));
                cmd.Parameters.Add(new SqlParameter("@Password", AppSettings.GetHash(password)));

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    reader.Close();
                    return null;
                }

                reader.Read();

                user = new User()
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Login = login,
                    Password = AppSettings.GetHash(password),
                    IsAdmin = reader.GetBoolean(2),
                };

                reader.Close();
            }

            return user;
        }

        public static List<User> GetAllAdmins()
        {
            var admins = new List<User>();

            string sqlExpr = "SELECT Id, Name, Login FROM Users WHERE IsAdmin = 1";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    admins.Add(new User()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Login = reader.GetString(2),
                        IsAdmin = true
                    });
                }

                reader.Close();
            }

            return admins;
        }

        public static bool CheckExistsUserByLogin(string login)
        {
            bool result;

            string sqlExpr = "SELECT COUNT(*) FROM Users WHERE Login = @login";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);
                cmd.Parameters.Add(new SqlParameter("@login", login));

                conn.Open();
                result = Convert.ToInt32(cmd.ExecuteScalar()) != 0;
            }

            return result;
        }

        public static bool CheckExistsUserByLoginWithoutCurrentId(int id, string login)
        {
            bool result;

            string sqlExpr = "SELECT COUNT(*) FROM Users WHERE Id <> @id AND Login = @login";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);
                cmd.Parameters.Add(new SqlParameter("@id", id));
                cmd.Parameters.Add(new SqlParameter("@login", login));

                conn.Open();
                result = Convert.ToInt32(cmd.ExecuteScalar()) != 0;
            }

            return result;
        }

        public static void Registration(User user)
        {
            string sqlExpr = "INSERT INTO Users (Name, Login, Password, IsAdmin) " +
                             "VALUES(@name, @login, @password, @isAdmin)";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);
                cmd.Parameters.Add(new SqlParameter("@name", user.Name));
                cmd.Parameters.Add(new SqlParameter("@login", user.Login));
                cmd.Parameters.Add(new SqlParameter("@password", AppSettings.GetHash(user.Password)));
                cmd.Parameters.Add(new SqlParameter("@isAdmin", user.IsAdmin));

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateUserPassword(int id, string password)
        {
            string sqlExpr = "Update Users SET Password = @password WHERE Id = @id";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);
                cmd.Parameters.Add(new SqlParameter("@id", id));
                cmd.Parameters.Add(new SqlParameter("@password", AppSettings.GetHash(password)));

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateUserNameAndLogin(User user)
        {
            string sqlExpr = "Update Users SET Name = @name, Login = @login WHERE Id = @id";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);
                cmd.Parameters.Add(new SqlParameter("@id", user.Id));
                cmd.Parameters.Add(new SqlParameter("@name", user.Name));
                cmd.Parameters.Add(new SqlParameter("@login", user.Login));

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteUser(int id)
        {
            string sqlExpr = "DELETE FROM Users WHERE Id = @id";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);
                cmd.Parameters.Add(new SqlParameter("@id", id));

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
