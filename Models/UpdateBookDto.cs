namespace lmsBackend.Models
{
    public class UpdateBookDto
    {
        public required string Title { get; set; }
        public required string Author { get; set; }
        public required string Category { get; set; }

        public required DateOnly EntrydDate { get; set; }
        public string? Description { get; set; }
    }
}
