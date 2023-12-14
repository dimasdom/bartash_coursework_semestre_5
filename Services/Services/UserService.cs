using Core.Entities;
using Core.Interfaces;
using Infrastracture.Core.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        // Конструктор, що впроваджує IUserRepository через Dependency Injection
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // Реалізація створення нового користувача
        public void CreateUser(UserModel user)
        {
            _userRepository.AddValue(user);
        }

        // Реалізація видалення користувача за ідентифікатором
        public void DeleteUser(Guid Id)
        {
            // Отримання існуючого користувача за ідентифікатором
            UserModel existingUser = _userRepository.GetValueById(Id);

            // Перевірка, чи знайдено користувача за ідентифікатором
            if (existingUser != null)
            {
                // Видалення користувача
                _userRepository.RemoveValue(existingUser);
            }
            // Додаткова логіка або обробка, якщо користувача з ідентифікатором Id не знайдено
        }

        // Реалізація отримання списку всіх користувачів
        public IEnumerable<UserModel> GetAll()
        {
            return _userRepository.GetAll();
        }

        // Реалізація отримання користувача за ідентифікатором
        public UserModel GetUser(Guid Id)
        {
            return _userRepository.GetValueById(Id);
        }

        // Реалізація оновлення інформації про користувача
        public void UpdateUser(UserModel user)
        {
            _userRepository.Update(user);
        }
    }

}
