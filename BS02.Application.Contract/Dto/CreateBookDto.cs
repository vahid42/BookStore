using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS02.Application.Contract.Dto
{
    public class CreateBookDto
    {
        public string? Title { get; set; }
        public double Price { get; set; }
    }
}
