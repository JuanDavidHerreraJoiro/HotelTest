using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Application.Exceptions
{
    public class NotFoundException: ApplicationException
    {
        public NotFoundException(string name,string key):base($" No se encontro {name} - {key}") 
        { 
        }
    }
}
