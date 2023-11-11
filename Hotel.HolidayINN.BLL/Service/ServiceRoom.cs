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
        public ServiceRoom(string path) : base(path)
        {
            repo = new Repository<Room>(path);
        }

        public bool AddRoom(RoomDTO room)
        {
            return repo.Create(mapper.Map<Room>(room));
        }
        public IEnumerable<RoomDTO> GetAllRooms()
        {
            return mapper.Map<IEnumerable<RoomDTO>>(repo.GetAll());
        }
        public void AddProperty
    }
}
