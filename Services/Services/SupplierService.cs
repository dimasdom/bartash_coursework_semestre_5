
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
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository repository;

        // Конструктор класу, приймає ISupplierRepository через Dependency Injection
        public SupplierService(ISupplierRepository repository)
        {
            this.repository = repository;
        }

        // Метод для створення нового постачальника
        public void CreateSupplier(Supplier supplier)
        {
            repository.AddValue(supplier);
        }

        // Метод для видалення постачальника за ідентифікатором
        public void DeleteSupplier(Guid Id)
        {
            // Отримання існуючого постачальника за ідентифікатором
            Supplier existingSupplier = repository.GetValueById(Id);

            // Перевірка, чи знайдений постачальник за ідентифікатором
            if (existingSupplier != null)
            {
                // Видалення постачальника
                repository.RemoveValue(existingSupplier);
            }
            // Додаткова логіка або обробка, якщо постачальник з ідентифікатором Id не знайдений
        }

        // Метод для отримання списку всіх постачальників
        public IEnumerable<Supplier> GetAll()
        {
            return repository.GetAll();
        }

        // Метод для отримання постачальника за ідентифікатором
        public Supplier GetSupplier(Guid Id)
        {
            return repository.GetValueById(Id);
        }

        // Метод для оновлення інформації про постачальника
        public void UpdateSupplier(Supplier supplier)
        {
            repository.Update(supplier);
        }
    }

}
