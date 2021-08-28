using iMedicalMVC.Fascade;
using iMedicalMVC.ViewModel.ContractType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iMedicalMVC.Controllers
{
    public class TenureTypeController : Controller
    {
        [HttpGet]
        public ActionResult ShowAll()
        {
            var showAllTenureType = new TenureTypeService().GetAll();

            return View(showAllTenureType);
        }

        [HttpGet]
        public ActionResult AddNew()
        {
            return View();
        }



        [HttpPost]
        public ActionResult AddNew(CreateTenureTypeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var tenureTypeService = new TenureTypeService();
                try
                {
                    tenureTypeService.ValidateTenureType(model);
                    tenureTypeService.AddTenureType(model);

                    return RedirectToAction("ShowAll", "TenureType");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError(string.Empty, e.Message);
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
        }
    }

    
}