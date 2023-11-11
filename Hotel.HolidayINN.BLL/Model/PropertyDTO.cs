using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.HolidayINN.BLL.Model
{
    public class PropertyDTO
    {
        public PropertyDTO()
        {

        }
        public PropertyDTO(string name, string description)
        {
            this.Name = name;
            this.Description = description;
            this.CreateDate = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
    }
}
