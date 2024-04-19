using Hotel.Domain.Commans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace domain.hotel.Class
{
    public class Booking:EntityBase
    {
        public string? IdBooking { get; set; }
        public bool State { get; set; }

        public Date? StartDate { get; set; }

        public Date? FinalDate { get; set; }

        public User? User { get; set; }
        public int? IdUser { get; set; }
        public List<Room>? Rooms { get; set; }

    }
}
