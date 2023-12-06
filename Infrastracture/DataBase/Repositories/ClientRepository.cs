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
    public class ClientRepository : IClientRepository
    {
        private readonly AppDbContext dbContext;

        public ClientRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AddValue(Client value)
        {
            dbContext.Clients.Add(value);
            dbContext.SaveChanges();
        }

        public IEnumerable<Client> GetAll()
        {
            return dbContext.Clients.ToList();
        }

        public Client GetValueById(object id)
        {
            return dbContext.Clients.First(x => x.Id == (Guid)id);
        }

        public IEnumerable<Client> GetValuesWithParams(Func<Client, bool> predicate)
        {
            return dbContext.Clients.Where(predicate);
        }

        public void RemoveValue(Client value)
        {
            dbContext.Clients.Remove(value); dbContext.SaveChanges();
        }

        public void Update(Client value)
        {
            throw new NotImplementedException();
        }
    }
}
