using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS01.Domain.DomainServices
{
    public interface IBookService
    {
        void DuplicateRecordCheckAddNew(string Title);
        void DuplicateRecordCheckEdit(Book book);

    }
}
