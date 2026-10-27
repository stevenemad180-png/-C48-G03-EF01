using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    internal class ProgramContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<authors> Authors { get; set; }
        public DbSet<category> Categories { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=.\SQLEXPRESS;Database=BOOKSTORE;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }
    }
}