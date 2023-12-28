using FilmsStorage.Models;
using FilmsStorage.Settings;
using System.Data.SqlClient;

namespace FilmsStorage.Database
{
    public class SelectionsDB
    {
        public static List<Selection> GetAllSelections()
        {
            var selections = new List<Selection>();

            string sqlExpr = "SELECT Id, Name FROM Selections";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    selections.Add(new Selection()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                    });
                }

                reader.Close();
            }

            return selections;
        }

        public static Selection? GetSelectionById(int id)
        {
            Selection selection;

            string sqlExpr = "SELECT Id, Name, Description FROM Selections WHERE Id = @id";

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

                selection = new Selection()
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Description = reader.GetString(2)
                };

                reader.Close();
            }

            return selection;
        }

        public static List<Film> GetSelectionFilmsById(int id)
        {
            var films = new List<Film>();

            string sqlExpr = "SELECT f.Id, RussianName, EnglishName, YearProduction, AgeRestriction, STRING_AGG(c.Name, ', ') " +
                             "FROM SelectionFilms AS sf " +
                             "JOIN Films AS f ON sf.FilmId = f.Id " +
                             "LEFT JOIN FilmCountries AS fc ON f.Id = fc.FilmId " +
                             "LEFT JOIN Countries AS c ON fc.CountryId = c.Id " +
                             "WHERE sf.SelectionId = @id " +
                             "GROUP BY f.Id, RussianName, EnglishName, YearProduction, AgeRestriction";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);
                cmd.Parameters.Add(new SqlParameter("@id", id));

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    films.Add(new Film()
                    {
                        Id = reader.GetInt32(0),
                        RussianName = reader.GetString(1),
                        EnglishName = reader.GetValue(2) is DBNull ? null : reader.GetString(2),
                        YearProduction = reader.GetInt32(3),
                        AgeRestriction = reader.GetString(4),
                        Countries = reader.GetValue(5) is DBNull ? null : reader.GetString(5),
                    });
                }

                reader.Close();
            }

            return films;
        }

        public static bool CheckExistsSelectionByName(string name)
        {
            bool result;

            string sqlExpr = "SELECT COUNT(*) FROM Selections WHERE Name = @name";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);
                cmd.Parameters.Add(new SqlParameter("@name", name));

                conn.Open();
                result = Convert.ToInt32(cmd.ExecuteScalar()) != 0;
            }

            return result;
        }

        public static bool CheckExistsSelectionByNameWithoutCurrentId(int id, string name)
        {
            bool result;

            string sqlExpr = "SELECT COUNT(*) FROM Selections WHERE Id <> @id AND Name = @name";

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

        public static bool CheckExistsFilmSelection(int filmId, int selectionId)
        {
            bool result;

            string sqlExpr = "SELECT COUNT(*) FROM SelectionFilms " +
                             "WHERE FilmId = @filmId AND SelectionId = @selectionId";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);
                cmd.Parameters.Add(new SqlParameter("@filmId", filmId));
                cmd.Parameters.Add(new SqlParameter("@selectionId", selectionId));

                conn.Open();
                result = Convert.ToInt32(cmd.ExecuteScalar()) != 0;
            }

            return result;
        }

        public static void CreateSelection(Selection selection)
        {
            string sqlExpr = "INSERT INTO Selections (Name, Description, UserId) VALUES (@name, @description, @userId)";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);
                cmd.Parameters.Add(new SqlParameter("@name", selection.Name));
                cmd.Parameters.Add(new SqlParameter("@description", selection.Description));
                cmd.Parameters.Add(new SqlParameter("@userId", AppSettings.User!.Id));

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void AddFilmInSelection(int filmId, int selectionId)
        {
            string sqlExpr = "INSERT INTO SelectionFilms (FilmId, SelectionId) VALUES (@filmId, @selectionId)";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);
                cmd.Parameters.Add(new SqlParameter("@filmId", filmId));
                cmd.Parameters.Add(new SqlParameter("@selectionId", selectionId));

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateSelection(Selection selection)
        {
            string sqlExpr = "Update Selections SET Name = @name, Description = @description WHERE Id = @id";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);
                cmd.Parameters.Add(new SqlParameter("@id", selection.Id));
                cmd.Parameters.Add(new SqlParameter("@name", selection.Name));
                cmd.Parameters.Add(new SqlParameter("@description", selection.Description));

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteSelection(int id)
        {
            string sqlExpr = "DELETE FROM Selections WHERE Id = @id";

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
