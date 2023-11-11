using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.HolidayINN
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly string path = "";

        public Repository(string path)
        {
            this.path = path;
            if (String.IsNullOrWhiteSpace(path))
                throw new Exception("You are invalid!");
        }
        public bool Create(T data)
        {
            try
            {
                using (var db = new LiteDatabase(path))
                {
                    var col = db.GetCollection<T>(typeof(T).Name);

                    var reult = col.Insert(data);
                    return true;
                }
            }
            catch(LiteException E)
            {
                var temp = E.Message;
                return false;
            }
            catch(Exception E)
            {
                return false;
            }

        }
        public bool Delete(int Id)
        {
            try
            {
                using (var db = new LiteDatabase(path))
                {
                    var col = db.GetCollection<T>(typeof(T).Name);
                    return col.Delete(Id);
                }
            }
            catch (Exception E)
            {
                return false;
            }
        }
        public IEnumerable<T> GetAll()
        {
            try
            {
                using (var db = new LiteDatabase(path))
                {
                    var col = db.GetCollection<T>(typeof(T).Name);
                    return col.FindAll();
                }
            }
            catch (Exception E)
            {
                return null;
            }
        }
        public T GetById(int Id)
        {
            try
            {
                using (var db = new LiteDatabase(path))
                {
                    var col = db.GetCollection<T>(typeof(T).Name);
                    return col.FindById(Id);
                }
            }
            catch (Exception E)
            {
                return null;
            }
        }
        public bool Update(T data)
        {
            try
            {
                using (var db = new LiteDatabase(path))
                {
                    var col = db.GetCollection<T>(typeof(T).Name);
                    return col.Update(data);
                }
            }
            catch (Exception E)
            {
                return false;
            }
        }
    }
}
