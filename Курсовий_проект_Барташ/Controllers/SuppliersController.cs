using Core.DTO;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Курсовий_проект_Барташ.Controllers
{
    public class SuppliersController : Controller
    {
        private readonly ISupplierService _supplierService;

        public SuppliersController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }

        public ActionResult Index(Guid Id)
        {
            return View();
        }
        public ActionResult Details(Guid Id)
        {
            var supplier = _supplierService.GetSupplier(Id);
            return View(supplier);
        }
        public ActionResult Edit(Guid Id)
        {
            return View(_supplierService.GetSupplier(Id));
        }
        [HttpPost]
        public ActionResult Edit(Supplier model)
        {
            _supplierService.UpdateSupplier(model);
            return View("Details", model);
        }
        public ActionResult Delete(Guid Id)
        {
            var model = _supplierService.GetSupplier(Id);
            _supplierService.DeleteSupplier(Id);
            return RedirectToAction("Details", "AutoBase", new { Id = model.AutoBaseId });
        }
        public ActionResult Create(Guid autoBaseId)
        {
            return View(new Supplier() { AutoBaseId=autoBaseId});
        }
        [HttpPost]
        public ActionResult Create(Supplier model)
        {
            _supplierService.CreateSupplier(model);
            return RedirectToAction("Details", "AutoBase", new { Id = model.AutoBaseId });
        }
    }
}
