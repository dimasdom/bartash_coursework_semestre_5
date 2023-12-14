using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastracture.Core.Interfaces.IRepositories
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        // Інтерфейс IEmployeeRepository успадковує всі методи та контракти визначені в IRepository<Employee>

        // Додаткові методи або функціональність, якщо потрібно
        // ...
    }

}
