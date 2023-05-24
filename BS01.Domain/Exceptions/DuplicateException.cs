using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS01.Domain.Exceptions
{
    public abstract class DuplicateException : Exception
    {
        protected DuplicateException(string message): base(message)
        {
        }
    }

}
