using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.HolidayINN.DAL.Model
{
    public class RoomProperty
    {
        public RoomProperty()
        {

        }
        public RoomProperty(int roomId, int propertyId)
        {
            this.RoomId = roomId;
            this.PropertyId = propertyId;
            this.CreateDate = DateTime.Now;
        }

        [BsonId]
        public int RoomPropertyId { get; set; }
        public DateTime CreateDate { get; set; }

        public int RoomId { get; set; }
        public Room Rooms { get; set; }

        public int PropertyId { get; set; }
        public Property  Properties { get; set; }
    }
}
