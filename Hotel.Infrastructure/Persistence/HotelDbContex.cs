using domain.hotel.Class;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Persistence
{
    public class HotelDbContex: DbContext 
    {
        public HotelDbContex(DbContextOptions<HotelDbContex> options):base(options)
        {
            
        }


        public DbSet<User> Users { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Room> Rooms { get; set; }  

        /*public override Task<int> SaveChangeAsycn()
        {

            return base.SaveChangesAsync();
        }*/

    }
}
