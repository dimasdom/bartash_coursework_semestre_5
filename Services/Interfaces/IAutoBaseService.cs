
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IAutoBaseService
    {
        // Отримання автобази за ідентифікатором
        public AutoBase GetAutoBase(Guid Id);

        // Видалення автобази за ідентифікатором
        public void DeleteAutoBase(Guid Id);

        // Оновлення інформації про автобазу
        public void UpdateAutoBase(AutoBase autoBase);

        // Отримання всіх автобаз
        public IEnumerable<AutoBase> GetAll();

        // Створення нової автобази
        public void CreateAutoBase(AutoBase autoBase);
    }

}
