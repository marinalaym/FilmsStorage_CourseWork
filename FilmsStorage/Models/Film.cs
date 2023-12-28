namespace FilmsStorage.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string RussianName { get; set; } = string.Empty;
        public string? EnglishName { get; set; }
        public int YearProduction { get; set; }
        public int Duration { get; set; }
        public DateTime PremiereDate { get; set; }
        public string AgeRestriction { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string? PathPhoto { get; set; }

        public string? Genres { get; set; }
        public List<Genre> GenresList { get; set; } = new();

        public string? Countries { get; set; }
        public List<Country> CountriesList { get; set; } = new();

        public List<FilmPerson> FilmPeople { get; set; } = new();
    }
}
