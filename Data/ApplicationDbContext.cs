using lmsBackend.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace lmsBackend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }

}
