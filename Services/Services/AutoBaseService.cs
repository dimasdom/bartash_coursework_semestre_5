
using Core.Entities;
using Core.Interfaces;
using Infrastracture.Core.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Core.Services
{
    public class AutoBaseService : IAutoBaseService
    {
        private readonly IAutoBaseRepository repository;

        // Конструктор класу, що приймає IAutoBaseRepository як параметр
        public AutoBaseService(IAutoBaseRepository repository)
        {
            this.repository = repository;
        }

        // Метод для створення нової автобази
        public void CreateAutoBase(AutoBase autoBase)
        {
            repository.AddValue(autoBase);
        }

        // Метод для видалення автобази за ідентифікатором
        public void DeleteAutoBase(Guid Id)
        {
            // Отримання існуючої автобази за ідентифікатором
            AutoBase existingAutoBase = repository.GetValueById(Id);

            // Перевірка, чи знайдено автобазу за ідентифікатором
            if (existingAutoBase != null)
            {
                // Видалення автобази
                repository.RemoveValue(existingAutoBase);
            }
            // Додаткова логіка або обробка, якщо автобаза з ідентифікатором Id не знайдена
        }

        // Метод для отримання списку всіх автобаз
        public IEnumerable<AutoBase> GetAll()
        {
            return repository.GetAll();
        }

        // Метод для отримання автобази за ідентифікатором
        public AutoBase GetAutoBase(Guid Id)
        {
            return repository.GetValueById(Id);
        }

        // Метод для оновлення інформації про автобазу
        public void UpdateAutoBase(AutoBase autoBase)
        {
            repository.Update(autoBase);
        }
    }

}
