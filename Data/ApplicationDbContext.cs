using Microsoft.EntityFrameworkCore;
using LibrarySystem.Models;

namespace LibrarySystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public required DbSet<Book> Books { get; set; }  // ✅ Required modifier
        public required DbSet<Author> Authors { get; set; }
        public required DbSet<Member> Members { get; set; }
        public required DbSet<Loan> Loans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
