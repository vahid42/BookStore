using BS01.Domain;
using Microsoft.EntityFrameworkCore;

namespace BS04.Infrastructure.EF
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoreContext context;

        public BookRepository(BookStoreContext context)
        {
            this.context = context;
        }

        public void Add(Book book)
        {
            context.Books.Add(book);
            Save();
        }

        public bool Exists(string title)
        {
            return context.Books.Any(x => x.Title == title);
        }

        public List<Book> GetAll()
        {
            return context.Books.ToList();
        }

        public Book GetById(int id)
        {
            return context.Books.FirstOrDefault(x => x.Id == id);
        }

        public Book GetById(string title)
        {
            return context.Books.FirstOrDefault(x => x.Title == title);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Book book)
        {
            context.Update(book);
            context.SaveChanges();
        }
    }
}