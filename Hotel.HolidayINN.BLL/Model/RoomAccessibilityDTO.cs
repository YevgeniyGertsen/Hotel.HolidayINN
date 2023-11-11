using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.HolidayINN.BLL.Model
{
    public class RoomAccessibilityDTO
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public int RoomId { get; set; }
        public RoomDTO Room { get; set; }
        public int UserId { get; set; }
        public UserDTO User { get; set; }
        public DateTime StartBooking { get; set; }
        public DateTime EndBooking { get; set; }
        public int GuestId { get; set; }
        public GuestDTO Guest { get; set; }

    }
}
