using FilmsStorage.Models;
using FilmsStorage.Settings;
using System.Data.SqlClient;

namespace FilmsStorage.Database
{
    public class CountriesDB
    {
        public static List<Country> GetAllCountries()
        {
            var countries = new List<Country>();

            string sqlExpr = "SELECT Id, Name FROM Countries";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    countries.Add(new Country()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                    });
                }

                reader.Close();
            }

            return countries;
        }

        public static Country? GetCountryById(int id)
        {
            Country country;

            string sqlExpr = "SELECT Id, Name FROM Countries WHERE Id = @id";

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

                country = new Country()
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                };

                reader.Close();
            }

            return country;
        }

        public static Country? GetCountryByName(string name)
        {
            Country country;

            string sqlExpr = "SELECT Id, Name FROM Countries WHERE Name = @name";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);
                cmd.Parameters.Add(new SqlParameter("@name", name));

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    reader.Close();
                    return null;
                }

                reader.Read();

                country = new Country()
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                };

                reader.Close();
            }

            return country;
        }

        public static bool CheckExistsCountryByName(string name)
        {
            bool result;

            string sqlExpr = "SELECT COUNT(*) FROM Countries WHERE Name = @name";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);
                cmd.Parameters.Add(new SqlParameter("@name", name));

                conn.Open();
                result = Convert.ToInt32(cmd.ExecuteScalar()) != 0;
            }

            return result;
        }

        public static bool CheckExistsCountryByNameWithoutCurrentId(int id, string name)
        {
            bool result;

            string sqlExpr = "SELECT COUNT(*) FROM Countries WHERE Id <> @id AND Name = @name";

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

        public static void CreateCountry(Country country)
        {
            string sqlExpr = "INSERT INTO Countries (Name) VALUES (@name)";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);
                cmd.Parameters.Add(new SqlParameter("@name", country.Name));

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateCountry(Country country)
        {
            string sqlExpr = "Update Countries SET Name = @name WHERE Id = @id";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);
                cmd.Parameters.Add(new SqlParameter("@id", country.Id));
                cmd.Parameters.Add(new SqlParameter("@name", country.Name));

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteCountry(int id)
        {
            string sqlExpr = "DELETE FROM Countries WHERE Id = @id";

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
