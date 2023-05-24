using BS01.Domain;
using BS01.Domain.DomainServices;
using BS02.Application.Contract;
using BS02.Application.Contract.Dto;

namespace BS03.Application
{
    public class BookAppliaction : IBookAppliaction
    {
        private readonly IBookRepository bookRepository;
        private readonly IBookService bookService;

        public BookAppliaction(IBookRepository bookRepository, IBookService bookService)
        {
            this.bookRepository = bookRepository;
            this.bookService = bookService;
        }

        public void Create(CreateBookDto book)
        {
            //cast book
            var item = new Book(book.Title, book.Price, bookService);

            //add to db
            bookRepository.Add(item);
        }


        public List<BookDto> GetBooks()
        {
            var list = new List<BookDto>();
            //get all from db
            var books = bookRepository.GetAll();
            // cast book to bookdto
            foreach (var book in books)
            {

                list.Add((BookDto)book);

            }

            return list;
        }

        public EditBookDto GetbyId(int id)
        {
            return (EditBookDto)bookRepository.GetById(id);
        }

        public void Edit(EditBookDto bookDto)
        {
            //get from db
            var book = bookRepository.GetById(bookDto.Id);

            //business logic
            book.Update(bookDto.Title, bookDto.Price, bookService);
            bookRepository.Save();
            
        }

        public void Remove(int id)
        {
            var book = bookRepository.GetById(id);
            //business logic
            book.Remove();
            bookRepository.Save();
        }

        public void Activate(int id)
        {
            var book = bookRepository.GetById(id);
            //business logic
            book.Activate();
            bookRepository.Save();
        }
    }
}