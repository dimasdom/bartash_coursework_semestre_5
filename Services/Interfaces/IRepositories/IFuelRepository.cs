using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastracture.Core.Interfaces.IRepositories
{
    public interface IFuelRepository : IRepository<FuelConsumption>
    {
        // Інтерфейс IFuelRepository успадковує всі методи та контракти визначені в IRepository<FuelConsumption>

        // Додаткові методи або функціональність, якщо потрібно
        // ...
    }

}
