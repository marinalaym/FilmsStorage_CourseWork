using FilmsStorage.Models;
using FilmsStorage.Settings;
using System.Data.SqlClient;

namespace FilmsStorage.Database
{
    public class PeopleDB
    {
        public static List<Person> GetAllPeople()
        {
            var people = new List<Person>();

            string sqlExpr = "SELECT p.Id, p.Name, p.DateBirth, p.DateDeath, c.Id, c.Name " +
                             "FROM People AS p " +
                             "JOIN Countries AS c ON p.CountryId = c.Id";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    people.Add(new Person()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        DateBirth = reader.GetDateTime(2),
                        DateDeath = reader.GetValue(3) is DBNull ? null : reader.GetDateTime(3),
                        CountryId = reader.GetInt32(4),
                        Country = new Country()
                        {
                            Id = reader.GetInt32(4),
                            Name = reader.GetString(5),
                        }
                    });
                }

                reader.Close();
            }

            return people;
        }

        public static List<Person> SearchPeopleByName(string name)
        {
            var people = new List<Person>();

            string sqlExpr = "SELECT p.Id, p.Name, p.DateBirth, p.DateDeath, c.Id, c.Name " +
                             "FROM People AS p " +
                             "JOIN Countries AS c ON p.CountryId = c.Id " +
                             "WHERE p.Name LIKE @name";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);
                cmd.Parameters.Add(new SqlParameter("@name", "%" + name + "%"));

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    people.Add(new Person()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        DateBirth = reader.GetDateTime(2),
                        DateDeath = reader.GetValue(3) is DBNull ? null : reader.GetDateTime(3),
                        CountryId = reader.GetInt32(4),
                        Country = new Country()
                        {
                            Id = reader.GetInt32(4),
                            Name = reader.GetString(5),
                        }
                    });
                }

                reader.Close();
            }

            return people;
        }

        public static Person? GetPersonById(int id)
        {
            Person person;

            string sqlExpr = "SELECT p.Id, p.Name, p.DateBirth, p.DateDeath, p.PathPhoto, c.Id, c.Name " +
                             "FROM People AS p " +
                             "JOIN Countries AS c ON p.CountryId = c.Id " +
                             "WHERE p.Id = @id";

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

                person = new Person()
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    DateBirth = reader.GetDateTime(2),
                    DateDeath = reader.GetValue(3) is DBNull ? null : reader.GetDateTime(3),
                    PathPhoto = reader.GetValue(4) is DBNull ? null : reader.GetString(4),
                    CountryId = reader.GetInt32(5),
                    Country = new Country()
                    {
                        Id = reader.GetInt32(5),
                        Name = reader.GetString(6),
                    }
                };

                reader.Close();
            }

            return person;
        }

        public static List<Film> GetPersonFilmsById(int id)
        {
            var films = new List<Film>();

            string sqlExpr = "SELECT f.Id, f.RussianName, f.EnglishName, f.YearProduction, min(p.Id), min(p.Name) " +
                             "FROM FilmPeople AS fp " +
                             "JOIN Films AS f ON fp.FilmId = f.Id " +
                             "JOIN Positions AS p ON fp.PositionId = p.Id " +
                             "WHERE fp.PersonId = @id " +
                             "GROUP BY f.Id, f.RussianName, f.EnglishName, f.YearProduction";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);
                cmd.Parameters.Add(new SqlParameter("@id", id));

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var film = new Film()
                    {
                        Id = reader.GetInt32(0),
                        RussianName = reader.GetString(1),
                        EnglishName = reader.GetValue(2) is DBNull ? null : reader.GetString(2),
                        YearProduction = reader.GetInt32(3),
                    };

                    film.FilmPeople.Add(new FilmPerson()
                    {
                        FilmId = reader.GetInt32(0),
                        PersonId = id,
                        PositionId = reader.GetInt32(4),
                        Position = new Position()
                        {
                            Id = reader.GetInt32(4),
                            Name = reader.GetString(5),
                        }
                    });

                    films.Add(film);
                }

                reader.Close();
            }

            return films;
        }

        public static void CreatePerson(Person person)
        {
            string sqlExpr = "INSERT INTO People (Name, DateBirth, DateDeath, PathPhoto, CountryId) " +
                             "VALUES (@name, @dateBirth, @dateDeath, @pathPhoto, @countryId)";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);
                cmd.Parameters.Add(new SqlParameter("@name", person.Name));
                cmd.Parameters.Add(new SqlParameter("@dateBirth", person.DateBirth));
                cmd.Parameters.Add(new SqlParameter("@dateDeath", person.DateDeath == null ? DBNull.Value : person.DateDeath));
                cmd.Parameters.Add(new SqlParameter("@pathPhoto", person.PathPhoto == null ? DBNull.Value : person.PathPhoto));
                cmd.Parameters.Add(new SqlParameter("@countryId", person.CountryId));

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdatePerson(Person person)
        {
            string sqlExpr = "Update People SET Name = @name, " +
                                               "DateBirth = @dateBirth, " +
                                               "DateDeath = @dateDeath, " +
                                               "PathPhoto = @pathPhoto, " +
                                               "CountryId = @countryId " +
                             "WHERE Id = @id";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);
                cmd.Parameters.Add(new SqlParameter("@id", person.Id));
                cmd.Parameters.Add(new SqlParameter("@name", person.Name));
                cmd.Parameters.Add(new SqlParameter("@dateBirth", person.DateBirth));
                cmd.Parameters.Add(new SqlParameter("@dateDeath", person.DateDeath == null ? DBNull.Value : person.DateDeath));
                cmd.Parameters.Add(new SqlParameter("@pathPhoto", person.PathPhoto == null ? DBNull.Value : person.PathPhoto));
                cmd.Parameters.Add(new SqlParameter("@countryId", person.CountryId));

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeletePerson(int id)
        {
            string sqlExpr = "DELETE FROM People WHERE Id = @id";

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
