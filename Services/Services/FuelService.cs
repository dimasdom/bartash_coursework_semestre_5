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
    public class FuelService : IFuelService
    {
        private readonly IFuelRepository repository;

        public FuelService(IFuelRepository repository)
        {
            this.repository = repository;
        }

        public void CreateFuelConsumptionRecord(FuelConsumption model)
        {
            repository.AddValue(model);
        }

        public void DeleteFuelConsumtionRecord(Guid id)
        {
            repository.RemoveValue(repository.GetValueById(id));
        }

        public FuelConsumption GetFuelConsumption(Guid id)
        {
            return repository.GetValueById(id);
        }

        public IEnumerable<FuelConsumption> GetFuelConsumptionList()
        {
            return repository.GetAll();
        }

        public void UpdateFuelConsumptionRecord(FuelConsumption fuelConsumption)
        {
            repository.Update(fuelConsumption);
        }
    }
}
