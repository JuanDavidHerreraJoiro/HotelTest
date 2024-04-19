using Hotel.Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Application.Features.Rooms.Commands.CreateRoom
{
    public class CreateRoomCommandHandler : IRequestHandler<CreateRoomCommand, Response>
    {
        
        public Task<Response> Handle(CreateRoomCommand request, CancellationToken cancellationToken)
        {
            //var roomExist = 
            return null;
        }
    }
}
