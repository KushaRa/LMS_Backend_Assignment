namespace lmsBackend.Models
{
    public class AddBookDto
    {
        public required string Title { get; set; } 
        public required string Author { get; set; }
        public required string Category { get; set; }

        public required DateOnly EntrydDate { get; set; }
        public string? Description { get; set; }
    }
}

//dto: Data Transfer objects, this transer data from one operation to another
