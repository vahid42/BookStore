using BS01.Domain;
using BS02.Application.Contract;
using BS02.Application.Contract.Dto;

namespace BS03.Application
{
    public class BookAppliaction : IBookAppliaction
    {
        private readonly IBookRepository bookRepository;

        public BookAppliaction(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
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
    }
}