using domain.hotel.Enums;
using Hotel.Domain.Commans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.hotel.Class
{
    public class Room: EntityBase
    {
        public int? IdRoom { get; set; }
        public bool? State { get; set; }
        public NumTypeRoom TypeRoom { get; set; }
        public int? NumberGuests { get; set; }
        public double? Price { get; set; }

        //relacion
        public Booking? Booking { get; set; }
        public int? IdBooking { get; set; }


    }
}
