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
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(FuelConsumption model)
        {
            return View();
        }
        public ActionResult Delete(Guid Id)
        {
            return View();
        }
        public ActionResult Create(Guid autoBaseId)
        {
            return View(new FuelConsumption() { AutoBaseId=autoBaseId});
        }
        [HttpPost]
        public ActionResult Create(FuelConsumption model)
        {
            _fuelService.CreateFuelConsumptionRecord(model);
            return View();
        }
    }
}
