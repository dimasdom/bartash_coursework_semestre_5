using Core.DTO;
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

        public EmployeeService(IEmployeeRepository repository)
        {
            this.repository = repository;
        }

        public void CreateEmployee(Employee autoBase)
        {
            repository.AddValue(autoBase);
        }

        public void DeleteEmployee(Guid Id)
        {
            repository.RemoveValue(repository.GetValueById(Id));
        }

        public IEnumerable<Employee> GetAll()
        {
            return repository.GetAll();
        }

        public Employee GetEmployee(Guid Id)
        {
            return repository.GetValueById(Id);
        }

        public void UpdateEmployee(Employee Employee)
        {
            repository.Update(Employee);
        }
    }
}
