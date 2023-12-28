using FilmsStorage.Models;
using FilmsStorage.Settings;
using System.Data.SqlClient;

namespace FilmsStorage.Database
{
    public class PositionsDB
    {
        public static List<Position> GetAllPositions()
        {
            var positions = new List<Position>();

            string sqlExpr = "SELECT Id, Name FROM Positions";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    positions.Add(new Position()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                    });
                }

                reader.Close();
            }
            return positions;
        }

        public static Position? GetPositionById(int id)
        {
            Position position;

            string sqlExpr = "SELECT Id, Name FROM Positions WHERE Id = @id";

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

                position = new Position()
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                };

                reader.Close();
            }

            return position;
        }

        public static bool CheckExistsPositionByName(string name)
        {
            bool result;

            string sqlExpr = "SELECT COUNT(*) FROM Positions WHERE Name = @name";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);
                cmd.Parameters.Add(new SqlParameter("@name", name));

                conn.Open();
                result = Convert.ToInt32(cmd.ExecuteScalar()) != 0;
            }

            return result;
        }

        public static bool CheckExistsPositionByNameWithoutCurrentId(int id, string name)
        {
            bool result;

            string sqlExpr = "SELECT COUNT(*) FROM Positions WHERE Id <> @id AND Name = @name";

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

        public static void CreatePosition(Position position)
        {
            string sqlExpr = "INSERT INTO Positions (Name) VALUES (@name)";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);
                cmd.Parameters.Add(new SqlParameter("@name", position.Name));

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdatePosition(Position position)
        {
            string sqlExpr = "Update Positions SET Name = @name WHERE Id = @id";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);
                cmd.Parameters.Add(new SqlParameter("@id", position.Id));
                cmd.Parameters.Add(new SqlParameter("@name", position.Name));

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeletePosition(int id)
        {
            string sqlExpr = "DELETE FROM Positions WHERE Id = @id";

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
