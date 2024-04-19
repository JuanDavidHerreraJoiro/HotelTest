using domain.hotel.Enums;
using Hotel.Domain.Commans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.hotel.Class
{
    public class User: EntityBase
    {
        public int? IdUser { get; set; }
        public string? Identification { get; set; }
        public NumTypesDocument TypeDocument { get; set; }
        public string? Name { get; set; }
        public string? Lastname { get; set; }

    }
}
