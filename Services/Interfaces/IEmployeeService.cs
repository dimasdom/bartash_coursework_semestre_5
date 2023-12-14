
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IEmployeeService
    {
        // Отримання працівника за ідентифікатором
        public Employee GetEmployee(Guid Id);

        // Видалення працівника за ідентифікатором
        public void DeleteEmployee(Guid Id);

        // Оновлення інформації про працівника
        public void UpdateEmployee(Employee employee);

        // Отримання всіх працівників
        public IEnumerable<Employee> GetAll();

        // Створення нового працівника
        public void CreateEmployee(Employee employee);
    }

}
