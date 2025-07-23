using Microsoft.EntityFrameworkCore;
using SimpleBookCatalog.Application.Interfaces;
using SimpleBookCatalog.Domain.Entites;
using SimpleBookCatalog.Infrastructure.Context;

namespace SimpleBookCatalog.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly SimpleCatalogDbContext context;
        public BookRepository(IDbContextFactory<SimpleCatalogDbContext> factory)
        {
            context = factory.CreateDbContext();
        }

        public async Task AddAsync(Book book)
        {
            context.Books.Add(book);
            await context.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(int id)
        {
            var book = await GetByIdAsync(id);
            if (book is not null)
            {
                context.Books.Remove(book);
                await context.SaveChangesAsync();
            }
        }

        public Task<List<Book>> GetAllAsync()
        {
            var books = context.Books.ToListAsync();
            return books;
        }

        public Task<Book?> GetByIdAsync(int id)
        {
            var book = context.Books.FirstOrDefaultAsync(b => b.Id == id);
            return book;
        }

        public async Task UpdateAsync(Book book)
        {
            /* If you want to update only specific properties, you can use the following approach:
            context.Attach(book); // Attach without marking as Modified
            context.Entry(book).Property(b => b.PublicationDate).IsModified = true;*/

            // If you want to update the entire entity, you can use the following approach:
            context.Entry(book).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }
    }
}
