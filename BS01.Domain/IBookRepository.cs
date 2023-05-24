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
        void Add(Book book);
        void Save();
        Book GetById(int id);
        Book GetById(string title);
        void Update(Book book);
        bool Exists(string title);
    }
}
