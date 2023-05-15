using BS01.Domain;

namespace BS04.Infrastructure.EF
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoreContext context;

        public BookRepository(BookStoreContext context)
        {
            this.context = context;
        }
        public List<Book> GetAll()
        {
            return context.Books.ToList();
        }
    }
}