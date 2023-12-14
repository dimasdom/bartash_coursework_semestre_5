using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUserService
    {
        // Отримання користувача за ідентифікатором
        public UserModel GetUser(Guid Id);

        // Видалення користувача за ідентифікатором
        public void DeleteUser(Guid Id);

        // Оновлення інформації про користувача
        public void UpdateUser(UserModel user);

        // Отримання всіх користувачів
        public IEnumerable<UserModel> GetAll();

        // Створення нового користувача
        public void CreateUser(UserModel user);
    }

}
