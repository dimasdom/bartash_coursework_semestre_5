using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastracture.Core.Interfaces.IRepositories
{
    public interface IUserRepository : IRepository<UserModel>
    {
        // Методи, що успадковуються від IRepository<UserModel>
        // Додаткові методи або функціональність, якщо потрібно
        // ...
    }
}

