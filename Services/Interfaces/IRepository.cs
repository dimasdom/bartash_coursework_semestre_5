using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IRepository<T> where T : class
    {
        // Отримання об'єкта за ідентифікатором
        public T GetValueById(object id);

        // Отримання всіх об'єктів типу T
        public IEnumerable<T> GetAll();

        // Отримання об'єктів з заданими параметрами
        public IEnumerable<T> GetValuesWithParams(Func<T, bool> predicate);

        // Додавання нового об'єкта
        public void AddValue(T value);

        // Видалення існуючого об'єкта
        public void RemoveValue(T value);

        // Оновлення існуючого об'єкта
        public void Update(T value);
    }

}
