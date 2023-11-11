using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.HolidayINN.DAL.Model
{
    public class Guest
    {
        public int Id { get; set; }
        public DateTime CreteTime { get;set; }
        public string FullName { get; set; }
    }
}