using BS01.Domain;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS02.Application.Contract.Dto
{
    public class BookDto
    {
        public int Id { get;  set; }
        public string? Title { get;  set; }
        public double Price { get;  set; }
        public bool IsDeleted { get;  set; }
        public string? CreateDatetime { get;  set; }

        public static implicit operator BookDto(Book book)
        {
            return new BookDto()
            {
                Id = book.Id,
                Title = book.Title,
                Price = book.Price,
                IsDeleted = book.IsDeleted,
                CreateDatetime = book.CreateDatetime.ToString(CultureInfo.InvariantCulture)

            };
        }
    }
}
