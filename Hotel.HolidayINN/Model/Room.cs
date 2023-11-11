using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.HolidayINN.DAL.Model
{
    public class Room
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string RoomNumber { get; set; }
        public int RoomType { get; set; }
        public int Floor { get; set; }
        public ICollection<RoomProperty> RoomProperties { get; set; }
        public ICollection<RoomAccessibility> RoomAccessibilities { get; set; }

    }
}
