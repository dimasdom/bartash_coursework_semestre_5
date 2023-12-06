using Core.DTO;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Курсовий_проект_Барташ.Controllers
{
    public class AdminController:Controller
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        public ActionResult Index()
        {
            _adminService.GetAllUsers();
            return View();
        }
        public ActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddUser(UserDTO model)
        {
            _adminService.CreateUser(model);
            return View();
        }
        public ActionResult DeleteUser(Guid Id)
        {
            _adminService.DeleteUser(Id);
            return View();
        }
        public ActionResult EditUser(Guid Id)
        {
            _adminService.GetUserById(Id);
            return View();
        }
        [HttpPost]
        public ActionResult EditUser(UserDTO model)
        {
            _adminService.UpdateUser(model);
            return View();
        }
        public ActionResult Details(Guid Id)
        {
            _adminService.GetUserById(Id);
            return View();
        }
    }
}
