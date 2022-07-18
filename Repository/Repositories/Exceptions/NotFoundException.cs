using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.Exceptions
{
    class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message) 
        {

        }
    }
}
