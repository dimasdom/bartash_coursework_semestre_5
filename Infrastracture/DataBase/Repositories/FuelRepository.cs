using Core.Entities;
using Core.Interfaces;
using Infrastracture.Core.Interfaces.IRepositories;
using Infrastracture.DataBase.ApplicationDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastracture.DataBase.Repositories
{
    public class FuelRepository : IFuelRepository
    {
        private readonly AppDbContext dbContext;

        /// <summary>
        /// Конструктор репозиторію витрат палива.
        /// </summary>
        /// <param name="dbContext">Контекст бази даних.</param>
        public FuelRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        /// <summary>
        /// Додає новий об'єкт витрати палива до бази даних.
        /// </summary>
        /// <param name="value">Об'єкт витрати палива для додавання.</param>
        public void AddValue(FuelConsumption value)
        {
            dbContext.FuelConsumption.Add(value);
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Отримує всі об'єкти витрат палива з бази даних.
        /// </summary>
        /// <returns>Список всіх об'єктів витрат палива.</returns>
        public IEnumerable<FuelConsumption> GetAll()
        {
            return dbContext.FuelConsumption.ToList();
        }

        /// <summary>
        /// Отримує об'єкт витрати палива за ідентифікатором з бази даних.
        /// </summary>
        /// <param name="id">Ідентифікатор об'єкта витрати палива.</param>
        /// <returns>Об'єкт витрати палива за вказаним ідентифікатором.</returns>
        public FuelConsumption GetValueById(object id)
        {
            return dbContext.FuelConsumption.First(x => x.Id == (Guid)id);
        }

        /// <summary>
        /// Отримує всі об'єкти витрат палива, які відповідають заданому предикату.
        /// </summary>
        /// <param name="predicate">Предикат для фільтрації об'єктів витрат палива.</param>
        /// <returns>Список об'єктів витрат палива, які відповідають предикату.</returns>
        public IEnumerable<FuelConsumption> GetValuesWithParams(Func<FuelConsumption, bool> predicate)
        {
            return dbContext.FuelConsumption.Where(predicate);
        }

        /// <summary>
        /// Видаляє об'єкт витрати палива з бази даних.
        /// </summary>
        /// <param name="value">Об'єкт витрати палива для видалення.</param>
        public void RemoveValue(FuelConsumption value)
        {
            dbContext.FuelConsumption.Remove(value);
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Оновлює існуючий об'єкт витрати палива в базі даних.
        /// </summary>
        /// <param name="value">Об'єкт витрати палива для оновлення.</param>
        public void Update(FuelConsumption value)
        {
            dbContext.FuelConsumption.Update(value);
            dbContext.SaveChanges();
        }
    }
}
