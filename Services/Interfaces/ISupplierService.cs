using Core.DTO;
using Core.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ISupplierService
    {
        public Supplier GetSupplier(Guid Id);
        public void DeleteSupplier(Guid Id);
        public void UpdateSupplier(Supplier Supplier);
        public IEnumerable<Supplier> GetAll();
        public void CreateSupplier(Supplier Supplier);
    }
}
