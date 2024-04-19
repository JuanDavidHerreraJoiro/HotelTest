using domain.hotel.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Application.Models.Identity
{
    public class UserRequest
    {
        public string? Identification { get; set; }
        public NumTypesDocument TypeDocument { get; set; }
        public string? Name { get; set; }
        public string? Lastname { get; set; }
    }
}
