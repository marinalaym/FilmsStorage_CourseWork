using FilmsStorage.Models;
using FilmsStorage.Settings;
using System.Data;
using System.Data.SqlClient;

namespace FilmsStorage.Database
{
    public class FilmsDB
    {
        private static string _sqlAllExpr =
                "SELECT selectFilmsGenres.* , STRING_AGG(c.Name, ', ') as Countries " +
                "FROM " +
                "( " +
                    "SELECT f.Id, f.RussianName, f.EnglishName, " +
                           "f.YearProduction, f.AgeRestriction, " +
                           "STRING_AGG( g.Name, ', ') as Genres " +
                    "FROM Films AS f " +
                    "LEFT JOIN FilmGenres AS fg ON f.Id = fg.FilmId " +
                    "LEFT JOIN Genres AS g ON fg.GenreId = g.Id " +
                    "GROUP BY f.Id, f.RussianName, f.EnglishName, " +
                             "f.YearProduction, f.AgeRestriction " +
                ") selectFilmsGenres " +
                "LEFT JOIN FilmCountries AS fc ON selectFilmsGenres.Id = fc.FilmId " +
                "LEFT JOIN Countries AS c ON fc.CountryId = c.Id " +
                "GROUP BY selectFilmsGenres.Id, selectFilmsGenres.RussianName, " +
                         "selectFilmsGenres.EnglishName, selectFilmsGenres.YearProduction, " +
                         "selectFilmsGenres.AgeRestriction, selectFilmsGenres.Genres";

        public static List<Film> GetAllFilms()
        {
            var films = new List<Film>();

            string sqlExpr = _sqlAllExpr;

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);

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
                        Genres = reader.GetValue(5) is DBNull ? null : reader.GetString(5),
                        Countries = reader.GetValue(6) is DBNull ? null : reader.GetString(6),
                    });
                }

                reader.Close();
            }

            return films;
        }

        public static List<Film> GetFiltredFilms(string condition)
        {
            var films = new List<Film>();

            string sqlExpr = $"SELECT * FROM ({_sqlAllExpr}) selectFilms WHERE {condition}";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);

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
                        Genres = reader.GetValue(5) is DBNull ? null : reader.GetString(5),
                        Countries = reader.GetValue(6) is DBNull ? null : reader.GetString(6),
                    });
                }

                reader.Close();
            }

            return films;
        }

        public static List<Film> SearchFilmsByName(string name)
        {
            var films = new List<Film>();

            string sqlExpr = "SELECT Id, RussianName, EnglishName, " +
                                "YearProduction, AgeRestriction " +
                             "FROM Films " +
                             "WHERE RussianName LIKE @name OR EnglishName LIKE @name";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);
                cmd.Parameters.Add(new SqlParameter("@name", "%" + name + "%"));

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
                    });
                }

                reader.Close();
            }

            return films;
        }

        public static Film? GetFilmById(int id)
        {
            Film film;

            string sqlExpr = "SELECT Id, RussianName, EnglishName, YearProduction, " +
                                    "Duration, PremiereDate, AgeRestriction, Description, PathPhoto " +
                             "FROM Films " +
                             "WHERE Id = @id";

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

                film = new Film()
                {
                    Id = reader.GetInt32(0),
                    RussianName = reader.GetString(1),
                    EnglishName = reader.GetValue(2) is DBNull ? null : reader.GetString(2),
                    YearProduction = reader.GetInt32(3),
                    Duration = reader.GetInt32(4),
                    PremiereDate = reader.GetDateTime(5),
                    AgeRestriction = reader.GetString(6),
                    Description = reader.GetString(7),
                    PathPhoto = reader.GetValue(8) is DBNull ? null : reader.GetString(8),
                };

                reader.Close();
            }

            return film;
        }

        public static List<Country> GetFilmCountriesById(int id)
        {
            var countries = new List<Country>();

            string sqlExpr = "SELECT c.Id, c.Name " +
                             "FROM FilmCountries AS fc " +
                             "JOIN Countries AS c ON fc.CountryId = c.Id " +
                             "WHERE fc.FilmId = @id " +
                             "ORDER BY c.Name";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);
                cmd.Parameters.Add(new SqlParameter("@id", id));

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

        public static List<Genre> GetFilmGenresById(int id)
        {
            var genres = new List<Genre>();

            string sqlExpr = "SELECT g.Id, g.Name " +
                             "FROM FilmGenres AS fg " +
                             "JOIN Genres AS g ON fg.GenreId = g.Id " +
                             "WHERE fg.FilmId = @id " +
                             "ORDER BY g.Name";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);
                cmd.Parameters.Add(new SqlParameter("@id", id));

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

        public static List<FilmPerson> GetFilmPeopleById(int id)
        {
            var filmPeople = new List<FilmPerson>();

            string sqlExpr = "SELECT p.Id, p.Name, pos.Id, pos.Name " +
                             "FROM FilmPeople AS fp " +
                             "JOIN People AS p ON fp.PersonId = p.Id " +
                             "JOIN Positions AS pos ON fp.PositionId = pos.Id " +
                             "WHERE fp.FilmId = @id";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);
                cmd.Parameters.Add(new SqlParameter("@id", id));

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    filmPeople.Add(new FilmPerson()
                    {
                        PersonId = reader.GetInt32(0),
                        Person = new Person()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                        },

                        PositionId = reader.GetInt32(2),
                        Position = new Position()
                        {
                            Id= reader.GetInt32(2),
                            Name = reader.GetString(3),
                        }
                    });
                }

                reader.Close();
            }

            return filmPeople;
        }

        public static void CreateFilm(Film film)
        {
            string sqlExpr = "INSERT INTO Films (" +
                                "RussianName, EnglishName, YearProduction, " +
                                "Duration, PremiereDate, AgeRestriction, " +
                                "Description, PathPhoto" +
                             ") " +
                             "VALUES (" +
                                "@russianName, @englishName, @yearProduction, " +
                                "@duration, @premiereDate, @ageRestriction, " +
                                "@description, @pathPhoto" +
                             ")";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);
                cmd.Parameters.Add(new SqlParameter("@russianName", film.RussianName));
                cmd.Parameters.Add(new SqlParameter("@englishName", film.EnglishName == null ? DBNull.Value : film.EnglishName));
                cmd.Parameters.Add(new SqlParameter("@yearProduction", film.YearProduction));
                cmd.Parameters.Add(new SqlParameter("@duration", film.Duration));
                cmd.Parameters.Add(new SqlParameter("@premiereDate", film.PremiereDate));
                cmd.Parameters.Add(new SqlParameter("@ageRestriction", film.AgeRestriction));
                cmd.Parameters.Add(new SqlParameter("@description", film.Description));
                cmd.Parameters.Add(new SqlParameter("@pathPhoto", film.PathPhoto == null ? DBNull.Value : film.PathPhoto));

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateFilm(Film film)
        {
            string sqlExpr = "Update Films SET " +
                                "RussianName = @russianName, " +
                                "EnglishName = @englishName, " +
                                "YearProduction = @yearProduction, " +
                                "Duration = @duration, " +
                                "PremiereDate = @premiereDate, " +
                                "AgeRestriction = @ageRestriction, " +
                                "Description = @description, " +
                                "PathPhoto = @pathPhoto " +
                             "WHERE Id = @id";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlExpr, conn);
                cmd.Parameters.Add(new SqlParameter("@id", film.Id));
                cmd.Parameters.Add(new SqlParameter("@russianName", film.RussianName));
                cmd.Parameters.Add(new SqlParameter("@englishName", film.EnglishName == null ? DBNull.Value : film.EnglishName));
                cmd.Parameters.Add(new SqlParameter("@yearProduction", film.YearProduction));
                cmd.Parameters.Add(new SqlParameter("@duration", film.Duration));
                cmd.Parameters.Add(new SqlParameter("@premiereDate", film.PremiereDate));
                cmd.Parameters.Add(new SqlParameter("@ageRestriction", film.AgeRestriction));
                cmd.Parameters.Add(new SqlParameter("@description", film.Description));
                cmd.Parameters.Add(new SqlParameter("@pathPhoto", film.PathPhoto == null ? DBNull.Value : film.PathPhoto));

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateFilmCountries(int filmId, List<int> countryIds)
        {
            var data = new DataTable();
            data.Columns.Add("id", typeof(int));

            foreach (var countryId in countryIds)
            {
                data.Rows.Add(countryId);
            }

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = conn.CreateCommand();

                cmd.CommandText = "dbo.UpdateFilmCountries";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@idFilm", SqlDbType.Int);
                cmd.Parameters["@idFilm"].Value = filmId;

                cmd.Parameters.Add("@idCountries", SqlDbType.Structured);
                cmd.Parameters["@idCountries"].TypeName = "intTable";
                cmd.Parameters["@idCountries"].Value = data;

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateFilmGenres(int filmId, List<int> genreIds)
        {
            var data = new DataTable();
            data.Columns.Add("id", typeof(int));

            foreach (var countryId in genreIds)
            {
                data.Rows.Add(countryId);
            }

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = conn.CreateCommand();

                cmd.CommandText = "dbo.UpdateFilmGenres";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@idFilm", SqlDbType.Int);
                cmd.Parameters["@idFilm"].Value = filmId;

                cmd.Parameters.Add("@idGenres", SqlDbType.Structured);
                cmd.Parameters["@idGenres"].TypeName = "intTable";
                cmd.Parameters["@idGenres"].Value = data;

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateFilmPeople(int filmId, List<FilmPerson> filmPeople)
        {
            string sqlDeleteExpr = "DELETE FROM FilmPeople WHERE FilmId = @filmId";

            string sqlInsertExpr = "INSERT INTO FilmPeople (FilmId, PersonId, PositionId) " +
                                   "VALUES (@filmId, @personId, @positionId)";

            using (var conn = new SqlConnection(AppSettings.ConnectionString))
            {
                var cmd = new SqlCommand(sqlDeleteExpr, conn);
                cmd.Parameters.Add(new SqlParameter("@filmId", filmId));

                conn.Open();
                cmd.ExecuteNonQuery();

                foreach (var filmPerson in filmPeople)
                {
                    cmd = new SqlCommand(sqlInsertExpr, conn);
                    cmd.Parameters.Add(new SqlParameter("@filmId", filmPerson.FilmId));
                    cmd.Parameters.Add(new SqlParameter("@personId", filmPerson.PersonId));
                    cmd.Parameters.Add(new SqlParameter("@positionId", filmPerson.PositionId));

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteFilm(int id)
        {
            string sqlExpr = "DELETE FROM Films WHERE Id = @id";

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
