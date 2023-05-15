using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS01.Domain
{
    public interface IBookRepository
    {
        List<Book> GetAll();
    }
}
