using FilmsStorage.Models;
using FilmsStorage.Settings;
using System.Data.SqlClient;

namespace FilmsStorage.Database
{
    public class GenresDB
    {
        public static List<Genre> GetAllGenres()
        {
            var genres = new List<Genre>();

            string sqlExpr = "SELECT Id, Name FROM Genres";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    genres.Add(new Genre()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                    });
                }

                reader.Close();
            }

            return genres;
        }

        public static Genre? GetGenreById(int id)
        {
            Genre genre;

            string sqlExpr = "SELECT Id, Name FROM Genres WHERE Id = @id";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);
                cmd.Parameters.Add(new SqlParameter("@id", id));

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    reader.Close();
                    return null;
                }

                reader.Read();

                genre = new Genre()
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                };

                reader.Close();
            }

            return genre;
        }

        public static bool CheckExistsGenreByName(string name)
        {
            bool result;

            string sqlExpr = "SELECT COUNT(*) FROM Genres WHERE Name = @name";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);
                cmd.Parameters.Add(new SqlParameter("@name", name));

                conn.Open();
                result = Convert.ToInt32(cmd.ExecuteScalar()) != 0;
            }

            return result;
        }

        public static bool CheckExistsGenreByNameWithoutCurrentId(int id, string name)
        {
            bool result;

            string sqlExpr = "SELECT COUNT(*) FROM Genres WHERE Id <> @id AND Name = @name";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);
                cmd.Parameters.Add(new SqlParameter("@id", id));
                cmd.Parameters.Add(new SqlParameter("@name", name));

                conn.Open();
                result = Convert.ToInt32(cmd.ExecuteScalar()) != 0;
            }

            return result;
        }

        public static void CreateGenre(Genre genre)
        {
            string sqlExpr = "INSERT INTO Genres (Name) VALUES (@name)";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);
                cmd.Parameters.Add(new SqlParameter("@name", genre.Name));

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateGenre(Genre genre)
        {
            string sqlExpr = "Update Genres SET Name = @name WHERE Id = @id";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);
                cmd.Parameters.Add(new SqlParameter("@id", genre.Id));
                cmd.Parameters.Add(new SqlParameter("@name", genre.Name));

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteGenre(int id)
        {
            string sqlExpr = "DELETE FROM Genres WHERE Id = @id";

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
