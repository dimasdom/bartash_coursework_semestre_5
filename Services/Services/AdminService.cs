using Core.DTO;
using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class AdminService : IAdminService
    {
        public void CreateUser(UserDTO user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(Guid Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDTO> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public UserModel GetUserById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(UserDTO user)
        {
            throw new NotImplementedException();
        }
    }
}
