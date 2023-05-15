using BS01.Domain;
using BS04.Infrastructure.EF.Mapping;
using Microsoft.EntityFrameworkCore;

namespace BS04.Infrastructure.EF
{
    public class BookStoreContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public BookStoreContext(DbContextOptions<BookStoreContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
