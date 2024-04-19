using domain.hotel.Class;
using domain.hotel.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Application.Models.Identity
{
    public class RoomRequest
    {
        public bool? State { get; set; }
        public NumTypeRoom TypeRoom { get; set; }
        public int? NumberGuests { get; set; }
        public double? Price { get; set; }
        public int? IdBooking { get; set; }
    }
}
