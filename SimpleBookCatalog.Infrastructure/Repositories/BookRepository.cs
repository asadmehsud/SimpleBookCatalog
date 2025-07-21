using Microsoft.EntityFrameworkCore;
using SimpleBookCatalog.Application.Interfaces;
using SimpleBookCatalog.Infrastructure.Context;

namespace SimpleBookCatalog.Infrastructure.Repositories
{
    public class BookRepository:IBookRepository
    {
        private readonly SimpleCatalogDbContext context;
        public BookRepository(IDbContextFactory<SimpleCatalogDbContext> factory)
        {
               context=factory.CreateDbContext();
        }
    }
}
