using Core.DTO;
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
        public FuelConsumption GetFuelConsumption(Guid id);
        public IEnumerable<FuelConsumption> GetFuelConsumptionList();
        public void DeleteFuelConsumtionRecord(Guid id);
        public void CreateFuelConsumptionRecord(FuelConsumption id);
        public void UpdateFuelConsumptionRecord(FuelConsumption fuelConsumption);
    }
}
