
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Курсовий_проект_Барташ.Controllers
{
    public class AutoBaseController:Controller
    {
        private readonly IAutoBaseService _autoBaseService;

        public AutoBaseController(IAutoBaseService autoBaseService)
        {
            _autoBaseService = autoBaseService;
        }

        public ActionResult Index()
        {
            var model = _autoBaseService.GetAll();
            return View(model);
        }
        public ActionResult Details(Guid Id)
        {
            
            return View(_autoBaseService.GetAutoBase(Id));
        }
        public ActionResult Edit(Guid Id)
        {
            return View(_autoBaseService.GetAutoBase(Id));
        }
        [HttpPost]
        public ActionResult Edit(AutoBase model)
        {
            model.UpdatedDate = DateTime.UtcNow;
            _autoBaseService.UpdateAutoBase(model);
            return View("Details", _autoBaseService.GetAutoBase(model.Id));
        }
        public ActionResult Delete(Guid Id)
        {
            _autoBaseService.DeleteAutoBase(Id);
            return RedirectToAction("Index");
        }
        public ActionResult Create()
        {
            return View("Create");
        }
        [HttpPost]
        public ActionResult Create(AutoBase model)
        {
            model.CreatedDate = DateTime.UtcNow;
            model.UpdatedDate = DateTime.UtcNow;
            _autoBaseService.CreateAutoBase(model);
            return RedirectToAction("Index");
        }
    }
}
