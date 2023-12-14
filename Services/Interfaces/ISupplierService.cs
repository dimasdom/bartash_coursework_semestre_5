
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
        // Отримання постачальника за ідентифікатором
        public Supplier GetSupplier(Guid Id);

        // Видалення постачальника за ідентифікатором
        public void DeleteSupplier(Guid Id);

        // Оновлення інформації про постачальника
        public void UpdateSupplier(Supplier supplier);

        // Отримання всіх постачальників
        public IEnumerable<Supplier> GetAll();

        // Створення нового постачальника
        public void CreateSupplier(Supplier supplier);
    }

}
