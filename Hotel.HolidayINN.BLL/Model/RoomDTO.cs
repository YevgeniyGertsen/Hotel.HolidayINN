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
        public int RoomId { get; set; }
        public DateTime CreateDate { get; set; }
        public string RoomNumber { get; set; }
        public RoomType RoomType { get; set; }
        public int Floor { get; set; }
        public List<RoomPropertyDTO> RoomProperties { get; set; }
        public ICollection<RoomAccessibilityDTO> RoomAccessibilities { get; set; }

        public string ShowProperties()
        {
            string res = "";
            foreach (RoomPropertyDTO prop in RoomProperties)
            {
                //foreach (var item in prop.Properties)
                //{
                //    res += string.Format("-{0}\n", item.Name);
                //}
            }
            return res;
        }
        public override string ToString()
        {
            string res = string.Format("{0}: {1}; Floor #{2}", RoomType, RoomNumber, Floor);
            return res;
        }
    }
}
