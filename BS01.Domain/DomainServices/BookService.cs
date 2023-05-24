using BS01.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS01.Domain.DomainServices
{
    public class BookService : IBookService
    {
        private readonly IBookRepository bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }
 

        public void DuplicateRecordCheckAddNew(string Title)
        {
            if (bookRepository.Exists(Title))
                throw new DuplicateRecordForTitleException(Title);
        }

        public void DuplicateRecordCheckEdit(Book book)
        {
            var item = bookRepository.GetById(book.Title);
            if (item !=null && item.Equals(book))
                return;

            if (bookRepository.Exists(book.Title))
                throw new DuplicateRecordForTitleException(book.Title);
        }
    }
}
