using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.HolidayINN.BLL.Model
{
    public class RoomPropertyDTO
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public int RoomId { get; set; }
        public ICollection<RoomDTO> Rooms { get; set; }
        public int PropertyId { get; set; }
        public ICollection<PropertyDTO>  Properties { get; set; }
    }
}
