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
    public class FuelRepository : IFuelRepository
    {
        private readonly AppDbContext dbContext;

        public FuelRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AddValue(FuelConsumption value)
        {
            dbContext.FuelConsumption.Add(value);
            dbContext.SaveChanges();
        }

        public IEnumerable<FuelConsumption> GetAll()
        {
            return dbContext.FuelConsumption.ToList();
        }

        public FuelConsumption GetValueById(object id)
        {
            return dbContext.FuelConsumption.First(x => x.Id == (Guid)id);
        }

        public IEnumerable<FuelConsumption> GetValuesWithParams(Func<FuelConsumption, bool> predicate)
        {
            return dbContext.FuelConsumption.Where(predicate);
        }

        public void RemoveValue(FuelConsumption value)
        {
            dbContext.FuelConsumption.Remove(value); dbContext.SaveChanges();
        }

        public void Update(FuelConsumption value)
        {
            dbContext.FuelConsumption.Update(value); dbContext.SaveChanges();
        }
    }
}
