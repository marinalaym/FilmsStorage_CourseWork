namespace FilmsStorage.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime DateBirth { get; set; }
        public DateTime? DateDeath { get; set; }
        public string? PathPhoto { get; set; }

        public int CountryId { get; set; }
        public Country? Country { get; set; }

        public List<Film> Films { get; set; } = new();
    }
}
