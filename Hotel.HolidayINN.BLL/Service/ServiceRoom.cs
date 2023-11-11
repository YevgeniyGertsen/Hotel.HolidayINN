using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.HolidayINN.BLL.Model;
using Hotel.HolidayINN.DAL.Model;

namespace Hotel.HolidayINN.BLL.Service
{
    public class ServiceRoom : Service
    {
        Repository<Room> repo = null;
        Repository<RoomProperty> repoRoomProp = null;
        public ServiceRoom(string path) : base(path)
        {
            repo = new Repository<Room>(path);
            repoRoomProp = new Repository<RoomProperty>(path);
        }

        public bool AddRoom(RoomDTO room)
        {
            return repo.Create(mapper.Map<Room>(room));
        }
        public IEnumerable<RoomDTO> GetAllRooms()
        {
            return mapper.Map<IEnumerable<RoomDTO>>(repo.GetAll());
        }
        public bool AddPropertyToRoom(int RoomId, int PropId)
        {
            return repoRoomProp.Create(new RoomProperty(RoomId, PropId));
        }
    }
}
