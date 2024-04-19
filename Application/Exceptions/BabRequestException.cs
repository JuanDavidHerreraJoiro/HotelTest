using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Application.Exceptions
{
    public class BabRequestExeption : ApplicationException
    {
        public BabRequestExeption(string message): base (message) 
        { 

        }
    }
}
