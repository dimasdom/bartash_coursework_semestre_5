using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IRepository<T> where T : class
    {
        public T GetValueById(object id);
        public IEnumerable<T> GetAll();
        public IEnumerable<T> GetValuesWithParams(Func<T,bool> predicate);
        public void AddValue(T value);
        public void RemoveValue(T value);
        public void Update(T value);
    }
}
