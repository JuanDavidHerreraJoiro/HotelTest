using domain.hotel.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hotel.Application.Models.Identity
{
    public class BookingRequest
    {
        public bool State { get; set; }

        public Date? StartDate { get; set; }

        public Date? FinalDate { get; set; }
        public int? IdUser { get; set; }
    }
}
