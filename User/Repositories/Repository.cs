using System;
using User.Models.Base;

namespace User.Repositories
{

    public class Repository<T> where T : BaseModel
    {
        public static List<T> _items = new List<T>();

        public void Create(T model)
        {
            _items.Add(model);
        }

        public T Get(Func<T, bool> func)
        {
            return _items.FirstOrDefault(func);
        }

        public List<T> GetALl()
        {
            return _items;
        }
    }
}

