using Core.DTO;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IAdminService
    {
        public void CreateUser(UserDTO user);
        public void UpdateUser(UserDTO user);
        public void DeleteUser(Guid Id);
        public UserModel GetUserById(Guid id);
        public IEnumerable<UserDTO> GetAllUsers();
    }
}
