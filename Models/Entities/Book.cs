namespace lmsBackend.Models.Entities
{
    public class Book
    {
        public Guid ID { get; set; }        
        public required string Title { get; set; } //to make nullable property add required field
        public required string Author { get; set; }
        public required string Category { get; set; }

        public required DateOnly EntrydDate { get; set; }
        public string? Description { get; set; }
    }
}
