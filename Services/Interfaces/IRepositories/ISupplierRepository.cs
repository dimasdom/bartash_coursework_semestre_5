using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastracture.Core.Interfaces.IRepositories
{
    public interface ISupplierRepository : IRepository<Supplier>
    {
        // Методи, що успадковуються від IRepository<Supplier>
        // Додаткові методи або функціональність, якщо потрібно
        // ...
    }
}

