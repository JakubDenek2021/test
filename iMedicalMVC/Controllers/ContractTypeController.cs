using iMedicalMVC.Fascade;
using iMedicalMVC.ViewModel.ContractType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iMedicalMVC.Controllers
{
    public class ContractTypeController : Controller
    {
        [HttpGet]
        public ActionResult ShowAll()
        {
            var showAllContractType = new ContractTypeService().GetAll();

            return View(showAllContractType);
        }

        [HttpGet]
        public ActionResult AddNew()
        {
            return View();
        }



        [HttpPost]
        public ActionResult AddNew(CreateContractTypeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var contractTypeService = new ContractTypeService();
                try
                {
                    contractTypeService.ValidateContractType(model);
                    contractTypeService.AddContractType(model);

                    return RedirectToAction("ShowAll", "ContractType");
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