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
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository repository;

        public SupplierService(ISupplierRepository repository)
        {
            this.repository = repository;
        }

        public void CreateSupplier(Supplier Supplier)
        {
            repository.AddValue(Supplier);
        }

        public void DeleteSupplier(Guid Id)
        {
            repository.RemoveValue(repository.GetValueById(Id));
        }

        public IEnumerable<Supplier> GetAll()
        {
            return repository.GetAll();
        }

        public Supplier GetSupplier(Guid Id)
        {
            return repository.GetValueById(Id);
        }

        public void UpdateSupplier(Supplier Supplier)
        {
            repository.Update(Supplier);
        }
    }
}
