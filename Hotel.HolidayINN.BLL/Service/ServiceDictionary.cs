using Hotel.HolidayINN.BLL.Model;
using Hotel.HolidayINN.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Hotel.HolidayINN.BLL.Service
{
    public class ServiceDictionary : Service
    {
        Repository<Property> propRepo = null;
        Repository<Furniture> furRepo = null;
        public ServiceDictionary(string path) : base(path)
        {
            propRepo = new Repository<Property>(path);
            furRepo = new Repository<Furniture>(path);
        }
        public bool AddProperty(PropertyDTO prop)
        {
            return propRepo.Create(mapper.Map<Property>(prop));
        }
        public bool AddFurniture(FurnitureDTO fur)
        {
            return furRepo.Create(mapper.Map<Furniture>(fur));
        }
    }
}
