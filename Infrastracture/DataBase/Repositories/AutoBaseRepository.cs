using Core.Entities;
using Core.Interfaces;
using Infrastracture.Core.Interfaces.IRepositories;
using Infrastracture.DataBase.ApplicationDbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastracture.DataBase.Repositories
{
    public class AutoBaseRepository : IAutoBaseRepository
    {
        private readonly AppDbContext dbContext;

        public AutoBaseRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AddValue(AutoBase value)
        {
            dbContext.AutoBases.Add(value);
            dbContext.SaveChanges();
        }

        public IEnumerable<AutoBase> GetAll()
        {
            return dbContext.AutoBases.ToList();
        }

        public AutoBase GetValueById(object id)
        {
            return dbContext.AutoBases
            .Include(ab => ab.FuelConsumption)
            .Include(ab => ab.Suppliers)
            .Include(ab => ab.Employees)
            .FirstOrDefault(ab => ab.Id == (Guid)id);
        }

        public IEnumerable<AutoBase> GetValuesWithParams(Func<AutoBase, bool> predicate)
        {
            return dbContext.AutoBases.Where(predicate);
        }

        public void RemoveValue(AutoBase value)
        {
            dbContext.AutoBases.Remove(value); dbContext.SaveChanges();
        }

        public void Update(AutoBase value)
        {
            dbContext.AutoBases.Update(value); dbContext.SaveChanges();
        }
    }
}
