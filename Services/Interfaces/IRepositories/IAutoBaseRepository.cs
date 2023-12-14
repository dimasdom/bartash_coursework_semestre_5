using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastracture.Core.Interfaces.IRepositories
{
    public interface IAutoBaseRepository : IRepository<AutoBase>
    {
        // Методи, що успадковуються від IRepository<AutoBase>
        // Додаткові методи або функціональність, якщо потрібно
        // ...
    }

}
