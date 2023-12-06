using Core.DTO;
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
        public Employee GetEmployee(Guid Id);
        public void DeleteEmployee(Guid Id);
        public void UpdateEmployee(Employee Employee);
        public IEnumerable<Employee> GetAll();
        public void CreateEmployee(Employee Employee);
    }
}
