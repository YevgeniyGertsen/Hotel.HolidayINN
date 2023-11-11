using Hotel.HolidayINN.BLL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.HolidayINN.BLL.Model
{
    public class RoomDTO
    {
        public RoomDTO()
        {

        }
        public RoomDTO(string roomNumber, RoomType roomType, int floor)
        {
            this.RoomNumber = roomNumber;
            this.RoomType = roomType;
            this.Floor = floor;
            this.CreateDate = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string RoomNumber { get; set; }
        public RoomType RoomType { get; set; }
        public int Floor { get; set; }
        public ICollection<RoomPropertyDTO> RoomProperties { get; set; }
        public ICollection<RoomAccessibilityDTO> RoomAccessibilities { get; set; }

    }
}
