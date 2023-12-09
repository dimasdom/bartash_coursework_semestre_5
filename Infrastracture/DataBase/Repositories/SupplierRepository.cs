using Core.Entities;
using Core.Interfaces;
using Infrastracture.Core.Interfaces.IRepositories;
using Infrastracture.DataBase.ApplicationDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastracture.DataBase.Repositories
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly AppDbContext dbContext;

        public SupplierRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AddValue(Supplier value)
        {
            dbContext.Suppliers.Add(value);
            dbContext.SaveChanges();
        }

        public IEnumerable<Supplier> GetAll()
        {
            return dbContext.Suppliers.ToList();
        }

        public Supplier GetValueById(object id)
        {
            return dbContext.Suppliers.First(x => x.Id == (Guid)id);
        }

        public IEnumerable<Supplier> GetValuesWithParams(Func<Supplier, bool> predicate)
        {
            return dbContext.Suppliers.Where(predicate);
        }

        public void RemoveValue(Supplier value)
        {
            dbContext.Suppliers.Remove(value); dbContext.SaveChanges();
        }

        public void Update(Supplier value)
        {
            dbContext.Suppliers.Update(value); dbContext.SaveChanges();
        }
    }
}
