
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
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository repository;

        // Конструктор класу, приймає IEmployeeRepository через Dependency Injection
        public EmployeeService(IEmployeeRepository repository)
        {
            this.repository = repository;
        }

        // Метод для створення нового працівника
        public void CreateEmployee(Employee employee)
        {
            repository.AddValue(employee);
        }

        // Метод для видалення працівника за ідентифікатором
        public void DeleteEmployee(Guid Id)
        {
            // Отримання існуючого працівника за ідентифікатором
            Employee existingEmployee = repository.GetValueById(Id);

            // Перевірка, чи знайдено працівника за ідентифікатором
            if (existingEmployee != null)
            {
                // Видалення працівника
                repository.RemoveValue(existingEmployee);
            }
            // Додаткова логіка або обробка, якщо працівник з ідентифікатором Id не знайдений
        }

        // Метод для отримання списку всіх працівників
        public IEnumerable<Employee> GetAll()
        {
            return repository.GetAll();
        }

        // Метод для отримання працівника за ідентифікатором
        public Employee GetEmployee(Guid Id)
        {
            return repository.GetValueById(Id);
        }

        // Метод для оновлення інформації про працівника
        public void UpdateEmployee(Employee employee)
        {
            repository.Update(employee);
        }
    }

}
