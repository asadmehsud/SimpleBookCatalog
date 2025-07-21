using Microsoft.EntityFrameworkCore;
using SimpleBookCatalog.Domain.Entites;

namespace SimpleBookCatalog.Infrastructure.Context
{
    public class SimpleCatalogDbContext(DbContextOptions<SimpleCatalogDbContext> options) : DbContext(options)
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Validation using FluentValidation Library
            //modelBuilder.Entity<Book>().Property(e => e.Title).IsRequired().HasMaxLength(50);
            //modelBuilder.Entity<Book>().Property(e=>e.Author).IsRequired().HasMaxLength(50);
        }
    }
}
