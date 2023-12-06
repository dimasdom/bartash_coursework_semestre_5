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
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext dbContext;
        public UserRepository(AppDbContext appDbContext)
        {
            dbContext = appDbContext;
        }

        public void AddValue(UserModel value)
        {
            dbContext.Users.Add(value);
            dbContext.SaveChanges();
        }

        public IEnumerable<UserModel> GetAll()
        {
            return dbContext.Users;
        }

        public UserModel GetValueById(object id)
        {
            return dbContext.Users.First(x => x.Id == id);
        }

        public IEnumerable<UserModel> GetValuesWithParams(Func<UserModel, bool> predicate)
        {
            return dbContext.Users.Where(predicate);
        }

        public void RemoveValue(UserModel value)
        {
            dbContext.Remove(value);
            dbContext.SaveChanges();
        }

        public void Update(UserModel value)
        {
            throw new NotImplementedException();
        }
    }
}
