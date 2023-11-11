using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.HolidayINN.BLL.Model
{
    public class FurnitureDTO
    {
        public FurnitureDTO()
        {

        }
        public FurnitureDTO(string name, string description, bool isSleepingPlace, int capacity)
        {
            this.Name = name;
            this.Description = description;
            this.IsSleepingPlace = isSleepingPlace;
            this.Capacity = capacity;
            this.CreateDate = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsSleepingPlace { get; set; } = false;
        public int Capacity { get; set; }
    }
}
