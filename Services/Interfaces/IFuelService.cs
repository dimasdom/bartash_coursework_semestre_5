
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IFuelService
    {
        // Отримання запису про споживання пального за ідентифікатором
        public FuelConsumption GetFuelConsumption(Guid id);

        // Отримання списку всіх записів про споживання пального
        public IEnumerable<FuelConsumption> GetFuelConsumptionList();

        // Видалення запису про споживання пального за ідентифікатором
        public void DeleteFuelConsumtionRecord(Guid id);

        // Створення нового запису про споживання пального
        public void CreateFuelConsumptionRecord(FuelConsumption fuelConsumption);

        // Оновлення інформації про запис споживання пального
        public void UpdateFuelConsumptionRecord(FuelConsumption fuelConsumption);
    }

}
