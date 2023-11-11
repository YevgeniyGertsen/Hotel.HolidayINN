using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.HolidayINN.BLL.Model
{
    public class GuestDTO
    {
        public int Id { get; set; }
        public DateTime CreteTime { get;set; }
        public string FullName { get; set; }
    }
}