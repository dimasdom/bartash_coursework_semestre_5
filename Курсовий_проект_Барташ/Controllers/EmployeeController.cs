using Core.DTO;
using Core.Entities;
using Core.Interfaces;
using Core.Services;
using Microsoft.AspNetCore.Mvc;
namespace Курсовий_проект_Барташ.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details(Guid Id)
        {
            return View(_employeeService.GetEmployee(Id));
        }
        public ActionResult Edit(Guid Id)
        {
            return View(_employeeService.GetEmployee(Id));
        }
        [HttpPost]
        public ActionResult Edit(Employee model)
        {
            _employeeService.UpdateEmployee(model);
            return View("Details",model);
        }
        public ActionResult Delete(Guid Id)
        {
            var model = _employeeService.GetEmployee(Id);
            _employeeService.DeleteEmployee(Id);
            return RedirectToAction("Details", "AutoBase", new { Id = model.AutoBaseId });
        }
        public ActionResult Create(Guid autoBaseId)
        {
            return View(new Employee() { AutoBaseId=autoBaseId});
        }
        [HttpPost]
        public ActionResult Create(Employee model)
        {
            _employeeService.CreateEmployee(model);
            return RedirectToAction("Details", "AutoBase", new { Id = model.AutoBaseId });
        }
    }
}
