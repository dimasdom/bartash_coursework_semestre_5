
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

        // Конструктор класу, приймає IFuelRepository через Dependency Injection
        public FuelService(IFuelRepository repository)
        {
            this.repository = repository;
        }

        // Метод для створення нового запису витрати палива
        public void CreateFuelConsumptionRecord(FuelConsumption model)
        {
            repository.AddValue(model);
        }

        // Метод для видалення запису витрати палива за ідентифікатором
        public void DeleteFuelConsumtionRecord(Guid id)
        {
            // Отримання існуючого запису витрати палива за ідентифікатором
            FuelConsumption existingFuelConsumption = repository.GetValueById(id);

            // Перевірка, чи знайдений запис витрати палива за ідентифікатором
            if (existingFuelConsumption != null)
            {
                // Видалення запису витрати палива
                repository.RemoveValue(existingFuelConsumption);
            }
            // Додаткова логіка або обробка, якщо запис витрати палива з ідентифікатором Id не знайдений
        }

        // Метод для отримання запису витрати палива за ідентифікатором
        public FuelConsumption GetFuelConsumption(Guid id)
        {
            return repository.GetValueById(id);
        }

        // Метод для отримання списку всіх записів витрати палива
        public IEnumerable<FuelConsumption> GetFuelConsumptionList()
        {
            return repository.GetAll();
        }

        // Метод для оновлення інформації про запис витрати палива
        public void UpdateFuelConsumptionRecord(FuelConsumption fuelConsumption)
        {
            repository.Update(fuelConsumption);
        }
    }

}
