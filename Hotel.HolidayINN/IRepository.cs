using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.HolidayINN
{
    public interface IRepository<T>
    {
        bool Create(T data);
        List<T> GetAll();
        T GetById(int Id);
        bool Update(T data);
        bool Delete(int Id);
    }
}
