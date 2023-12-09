using Core.DTO;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Курсовий_проект_Барташ.Controllers
{
    public class FuelController : Controller
    {
        private readonly IFuelService _fuelService;

        public FuelController(IFuelService fuelService)
        {
            _fuelService = fuelService;
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details(Guid Id)
        {
            return View(_fuelService.GetFuelConsumption(Id));
        }
        public ActionResult Edit(Guid Id)
        {
            return View(_fuelService.GetFuelConsumption(Id));
        }
        [HttpPost]
        public ActionResult Edit(FuelConsumption model)
        {
            _fuelService.UpdateFuelConsumptionRecord(model);
            return View("Details",model);
        }
        public ActionResult Delete(Guid Id)
        {
            var model = _fuelService.GetFuelConsumption(Id);
            _fuelService.DeleteFuelConsumtionRecord(Id);
            return RedirectToAction("Details", "AutoBase", new { Id  =  model.AutoBaseId });
        }
        public ActionResult Create(Guid autoBaseId)
        {
            return View(new FuelConsumption() { AutoBaseId=autoBaseId});
        }
        [HttpPost]
        public ActionResult Create(FuelConsumption model)
        {
            _fuelService.CreateFuelConsumptionRecord(model);
            return RedirectToAction("Details", "AutoBase", new { Id = model.AutoBaseId });
        }
    }
}
