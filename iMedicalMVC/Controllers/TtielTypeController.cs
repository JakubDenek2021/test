using iMedicalMVC.Fascade;
using iMedicalMVC.ViewModel.ContractType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iMedicalMVC.Controllers
{
    public class TitleTypeController : Controller
    {
        [HttpGet]
        public ActionResult ShowAll()
        {
            var showAllTitleType = new TitleTypeService().GetAll();

            return View(showAllTitleType);
        }

        [HttpGet]
        public ActionResult AddNew()
        {
            return View();
        }



        [HttpPost]
        public ActionResult AddNew(CreateTitleTypeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var titleTypeService = new TitleTypeService();
                try
                {
                    titleTypeService.ValidateTitleType(model);
                   titleTypeService.AddTitleType(model);

                    return RedirectToAction("ShowAll", "TitleType");
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