using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.HolidayINN.BLL.Enums;
using Hotel.HolidayINN.BLL.Model;
using Hotel.HolidayINN.BLL.Service;

namespace Hotel.HolidayINN.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceRoom serviceRoom = new ServiceRoom(@"C:\Temp\Hotel.db");
            ServiceDictionary serviceDictionary = new ServiceDictionary(@"C:\Temp\Hotel.db");



            if (serviceDictionary.AddProperty(new PropertyDTO("WiFi", "")))
                System.Console.WriteLine("Property successfully added");
            if (serviceDictionary.AddProperty(new PropertyDTO("Refrigerator", "")))
                System.Console.WriteLine("Property successfully added");
            if (serviceDictionary.AddProperty(new PropertyDTO("Dryer", "")))
                System.Console.WriteLine("Property successfully added");

            if (serviceDictionary.AddFurniture(new FurnitureDTO("Sofa", "", true, 1)))
                System.Console.WriteLine("Furniture successfully added");
            if (serviceDictionary.AddFurniture(new FurnitureDTO("Bed", "", true, 2)))
                System.Console.WriteLine("Furniture successfully added");

            if (serviceRoom.AddRoom(new RoomDTO("101A", RoomType.Standart, 1)))
                System.Console.WriteLine("Room added");

            if (serviceRoom.AddPropertyToRoom(1, 1))
                System.Console.WriteLine("Property added to room");
            if (serviceRoom.AddPropertyToRoom(1, 2))
                System.Console.WriteLine("Property added to room");
            if (serviceRoom.AddPropertyToRoom(2, 1))
                System.Console.WriteLine("Property added to room");
            if (serviceRoom.AddPropertyToRoom(2, 2))
                System.Console.WriteLine("Property added to room");
            if (serviceRoom.AddPropertyToRoom(2, 3))
                System.Console.WriteLine("Property added to room");

            foreach (RoomDTO room in serviceRoom.GetAllRooms())
            {
                System.Console.WriteLine(room);
                System.Console.WriteLine(room.ShowProperties());
            }


        }
    }
}
