using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.HolidayINN.DAL.Model
{
    public class RoomFurniture
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public int RoomId { get; set; }
        public ICollection<Room> Rooms { get; set; }
        public int FurnitureId { get; set; }
        public ICollection<Furniture> Furnitures { get; set; }
    }
}
