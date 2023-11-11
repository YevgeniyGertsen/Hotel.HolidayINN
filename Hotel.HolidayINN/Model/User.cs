using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.HolidayINN.DAL.Model
{
    public class User
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string FullName { get; set; }
        public ICollection<RoomAccessibility> RoomAccessibilities { get;  set; }
    }
}