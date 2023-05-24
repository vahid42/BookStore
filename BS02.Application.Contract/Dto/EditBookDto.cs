using BS01.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS02.Application.Contract.Dto
{
    public class EditBookDto: CreateBookDto
    {
        public int Id { get; set; }
        public static implicit operator EditBookDto(Book book)
        {
            return new EditBookDto()
            {
                Id = book.Id,
                Title = book.Title,
                Price = book.Price,
            };
        }
    }
}
