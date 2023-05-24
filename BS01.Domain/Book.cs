using BS01.Domain.DomainServices;
using System.Drawing;

namespace BS01.Domain
{
    public class Book
    {
        public int Id { get; private set; }
        public string? Title { get; private set; }
        public double Price { get; private set; }
        public bool IsDeleted { get; private set; }
        public DateTime CreateDatetime { get; private set; }


        public Book()
        {

        }

        public Book(string tilte, double price, IBookService bookService)
        {
            validation(tilte, price);
            bookService.DuplicateRecordCheckAddNew(tilte);
            Title = tilte;
            Price = price;
            IsDeleted = false;
            CreateDatetime = DateTime.Now;

        }

        public void Update(string tilte, double price, IBookService bookService)
        {
            validation(tilte, price);
            Title = tilte;
            Price = price;
            bookService.DuplicateRecordCheckEdit(this);

        }

        public void Remove()
        {
            IsDeleted = true;
        }

        public void Activate()
        {
            IsDeleted = false;
        }
        private void validation(string tilte, double price)
        {
            if (string.IsNullOrEmpty(tilte))
                throw new ArgumentNullException();
            if (price < 1)
                throw new ArgumentOutOfRangeException();

        }


        public override bool Equals(object? obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Book book = (Book)obj;
                return (Id == book.Id) && (Title == book.Title);
            }
        }
    }
}