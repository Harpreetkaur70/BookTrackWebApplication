using Microsoft.EntityFrameworkCore;

namespace BookTrackWebApplication.Models
{
    public class ApplicationDbContext : DbContext
    {
        private readonly string _connString = "Server=.;Database=BookDb2; Trusted_Connection=True;";

        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connString);
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryType> categoryTypes { get; set; }

    }
}
