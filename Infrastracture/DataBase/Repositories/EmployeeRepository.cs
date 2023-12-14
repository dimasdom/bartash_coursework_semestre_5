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
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext dbContext;

        /// <summary>
        /// Конструктор репозиторію співробітників.
        /// </summary>
        /// <param name="dbContext">Контекст бази даних.</param>
        public EmployeeRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        /// <summary>
        /// Додає нового співробітника до бази даних.
        /// </summary>
        /// <param name="value">Об'єкт співробітника для додавання.</param>
        public void AddValue(Employee value)
        {
            dbContext.Employees.Add(value);
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Отримує всіх співробітників з бази даних.
        /// </summary>
        /// <returns>Список всіх об'єктів співробітників.</returns>
        public IEnumerable<Employee> GetAll()
        {
            return dbContext.Employees.ToList();
        }

        /// <summary>
        /// Отримує співробітника за ідентифікатором з бази даних.
        /// </summary>
        /// <param name="id">Ідентифікатор співробітника.</param>
        /// <returns>Об'єкт співробітника за вказаним ідентифікатором.</returns>
        public Employee GetValueById(object id)
        {
            return dbContext.Employees.First(x => x.Id == (Guid)id);
        }

        /// <summary>
        /// Отримує всіх співробітників, які відповідають заданому предикату.
        /// </summary>
        /// <param name="predicate">Предикат для фільтрації співробітників.</param>
        /// <returns>Список співробітників, які відповідають предикату.</returns>
        public IEnumerable<Employee> GetValuesWithParams(Func<Employee, bool> predicate)
        {
            return dbContext.Employees.Where(predicate);
        }

        /// <summary>
        /// Видаляє співробітника з бази даних.
        /// </summary>
        /// <param name="value">Об'єкт співробітника для видалення.</param>
        public void RemoveValue(Employee value)
        {
            dbContext.Employees.Remove(value);
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Оновлює існуючого співробітника в базі даних.
        /// </summary>
        /// <param name="value">Об'єкт співробітника для оновлення.</param>
        public void Update(Employee value)
        {
            dbContext.Employees.Update(value);
            dbContext.SaveChanges();
        }
    }
}
