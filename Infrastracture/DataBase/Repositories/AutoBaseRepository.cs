using Core.Entities;
using Core.Interfaces;
using Infrastracture.Core.Interfaces.IRepositories;
using Infrastracture.DataBase.ApplicationDbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastracture.DataBase.Repositories
{
    public class AutoBaseRepository : IAutoBaseRepository
    {
        private readonly AppDbContext dbContext;

        /// <summary>
        /// Конструктор репозиторію автобаз.
        /// </summary>
        /// <param name="dbContext">Контекст бази даних.</param>
        public AutoBaseRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        /// <summary>
        /// Додає новий об'єкт автобази до бази даних.
        /// </summary>
        /// <param name="value">Об'єкт автобази для додавання.</param>
        public void AddValue(AutoBase value)
        {
            dbContext.AutoBases.Add(value);
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Отримує всі об'єкти автобаз з бази даних.
        /// </summary>
        /// <returns>Список всіх об'єктів автобаз.</returns>
        public IEnumerable<AutoBase> GetAll()
        {
            return dbContext.AutoBases.ToList();
        }

        /// <summary>
        /// Отримує об'єкт автобази за ідентифікатором з бази даних.
        /// </summary>
        /// <param name="id">Ідентифікатор об'єкта автобази.</param>
        /// <returns>Об'єкт автобази за вказаним ідентифікатором.</returns>
        public AutoBase GetValueById(object id)
        {
            return dbContext.AutoBases
                .Include(ab => ab.FuelConsumption)
                .Include(ab => ab.Suppliers)
                .Include(ab => ab.Employees)
                .FirstOrDefault(ab => ab.Id == (Guid)id);
        }

        /// <summary>
        /// Отримує всі об'єкти автобаз, які відповідають заданому предикату.
        /// </summary>
        /// <param name="predicate">Предикат для фільтрації об'єктів автобаз.</param>
        /// <returns>Список об'єктів автобаз, які відповідають предикату.</returns>
        public IEnumerable<AutoBase> GetValuesWithParams(Func<AutoBase, bool> predicate)
        {
            return dbContext.AutoBases.Where(predicate);
        }

        /// <summary>
        /// Видаляє об'єкт автобази з бази даних.
        /// </summary>
        /// <param name="value">Об'єкт автобази для видалення.</param>
        public void RemoveValue(AutoBase value)
        {
            dbContext.AutoBases.Remove(value);
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Оновлює існуючий об'єкт автобази в базі даних.
        /// </summary>
        /// <param name="value">Об'єкт автобази для оновлення.</param>
        public void Update(AutoBase value)
        {
            dbContext.AutoBases.Update(value);
            dbContext.SaveChanges();
        }
    }

}
