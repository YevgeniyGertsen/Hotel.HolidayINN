using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.HolidayINN.DAL.Model;
using Hotel.HolidayINN.BLL.Model;

namespace Hotel.HolidayINN.BLL.Service
{
    public abstract class Service
    {
        private readonly string path = "";
        protected IMapper mapper = null;
        public Service(string path)
        {
            this.path = path;
            if (string.IsNullOrWhiteSpace(path))
                throw new Exception("You are invalid");

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<RoomProperty, RoomPropertyDTO>().ReverseMap();
                cfg.CreateMap<RoomFurniture, RoomFurnitureDTO>().ReverseMap();
                cfg.CreateMap<Property, PropertyDTO>().ReverseMap();
                cfg.CreateMap<Furniture, FurnitureDTO>().ReverseMap();
                cfg.CreateMap<Room, RoomDTO>().ReverseMap();
            });

            mapper = config.CreateMapper();
        }
    }
}
