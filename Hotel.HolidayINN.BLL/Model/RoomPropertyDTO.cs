using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.HolidayINN.BLL.Model
{
    public class RoomPropertyDTO
    {
        public int RoomPropertyId { get; set; }
        public DateTime CreateDate { get; set; }
        public int RoomId { get; set; }
        public RoomDTO Rooms { get; set; }
        public int PropertyId { get; set; }
        public PropertyDTO  Properties { get; set; }
    }
}
