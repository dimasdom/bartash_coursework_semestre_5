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
    public class SupplierRepository : ISupplierRepository
    {
        private readonly AppDbContext dbContext;

        /// <summary>
        /// Конструктор репозиторію постачальників.
        /// </summary>
        /// <param name="dbContext">Контекст бази даних.</param>
        public SupplierRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        /// <summary>
        /// Додає нового постачальника до бази даних.
        /// </summary>
        /// <param name="value">Об'єкт постачальника для додавання.</param>
        public void AddValue(Supplier value)
        {
            dbContext.Suppliers.Add(value);
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Отримує всіх постачальників з бази даних.
        /// </summary>
        /// <returns>Список всіх об'єктів постачальників.</returns>
        public IEnumerable<Supplier> GetAll()
        {
            return dbContext.Suppliers.ToList();
        }

        /// <summary>
        /// Отримує постачальника за ідентифікатором з бази даних.
        /// </summary>
        /// <param name="id">Ідентифікатор постачальника.</param>
        /// <returns>Об'єкт постачальника за вказаним ідентифікатором.</returns>
        public Supplier GetValueById(object id)
        {
            return dbContext.Suppliers.First(x => x.Id == (Guid)id);
        }

        /// <summary>
        /// Отримує всіх постачальників, які відповідають заданому предикату.
        /// </summary>
        /// <param name="predicate">Предикат для фільтрації постачальників.</param>
        /// <returns>Список постачальників, які відповідають предикату.</returns>
        public IEnumerable<Supplier> GetValuesWithParams(Func<Supplier, bool> predicate)
        {
            return dbContext.Suppliers.Where(predicate);
        }

        /// <summary>
        /// Видаляє постачальника з бази даних.
        /// </summary>
        /// <param name="value">Об'єкт постачальника для видалення.</param>
        public void RemoveValue(Supplier value)
        {
            dbContext.Suppliers.Remove(value);
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Оновлює існуючого постачальника в базі даних.
        /// </summary>
        /// <param name="value">Об'єкт постачальника для оновлення.</param>
        public void Update(Supplier value)
        {
            dbContext.Suppliers.Update(value);
            dbContext.SaveChanges();
        }
    }
}
