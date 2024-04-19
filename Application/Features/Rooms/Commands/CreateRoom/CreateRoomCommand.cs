using domain.hotel.Enums;
using Hotel.Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Application.Features.Rooms.Commands.CreateRoom
{
    public class CreateRoomCommand: IRequest<Response>
    {
        public int? IdRoom { get; set; }
        public bool? State { get; set; }
        public NumTypeRoom TypeRoom { get; set; }
        public int? NumberGuests { get; set; }
        public double? Price { get; set; }
        public int? IdBooking { get; set; }
    }
}
