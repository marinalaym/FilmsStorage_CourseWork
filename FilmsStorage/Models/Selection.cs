namespace FilmsStorage.Models
{
    public class Selection
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int UserId { get; set; }

        public List<Film> Films { get; set; } = new();
    }
}
