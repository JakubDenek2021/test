using iMedicalMVC.Fascade;
using iMedicalMVC.ViewModel.ContractType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iMedicalMVC.Controllers
{
    public class VisitTypeController : Controller
    {
        [HttpGet]
        public ActionResult ShowAll()
        {
            var showAllVisitType = new VisitTypeService().GetAll();

            return View(showAllVisitType);
        }

        [HttpGet]
        public ActionResult AddNew()
        {
            return View();
        }



        [HttpPost]
        public ActionResult AddNew(CreateVisitTypeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var visitTypeService = new VisitTypeService();
                try
                {
                    visitTypeService.ValidateVisitType(model);
                    visitTypeService.AddVisitType(model);

                    return RedirectToAction("ShowAll", "VisitType");
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