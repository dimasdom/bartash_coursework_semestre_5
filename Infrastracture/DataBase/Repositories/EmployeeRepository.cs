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

        public EmployeeRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AddValue(Employee value)
        {
            dbContext.Employees.Add(value);
            dbContext.SaveChanges();
        }

        public IEnumerable<Employee> GetAll()
        {
            return dbContext.Employees.ToList();
        }

        public Employee GetValueById(object id)
        {
            return dbContext.Employees.First(x => x.Id == (Guid)id);
        }

        public IEnumerable<Employee> GetValuesWithParams(Func<Employee, bool> predicate)
        {
            return dbContext.Employees.Where(predicate);
        }

        public void RemoveValue(Employee value)
        {
            dbContext.Employees.Remove(value); dbContext.SaveChanges();
        }

        public void Update(Employee value)
        {
            throw new NotImplementedException();
        }
    }
}
