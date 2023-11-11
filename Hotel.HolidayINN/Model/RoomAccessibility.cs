using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.HolidayINN.DAL.Model
{
    public class RoomAccessibility
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime StartBooking { get; set; }
        public DateTime EndBooking { get; set; }
        public int GuestId { get; set; }
        public Guest Guest { get; set; }

    }
}
