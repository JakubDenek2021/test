using iMedicalMVC.Fascade;
using iMedicalMVC.ViewModel.ContractType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iMedicalMVC.Controllers
{
    public class MedicalExaminationTypeController : Controller
    {
        [HttpGet]
        public ActionResult ShowAll()
        {
            var showAllMedicalExaminationType = new MedicalExaminationTypeService().GetAll();

            return View(showAllMedicalExaminationType);
        }

        [HttpGet]
        public ActionResult AddNew()
        {
            return View();
        }



        [HttpPost]
        public ActionResult AddNew(CreateMedicalExaminationTypeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var medicalExaminationType = new MedicalExaminationTypeService();
                try
                {
                    medicalExaminationType.ValidateMedicalExaminationType(model);
                    medicalExaminationType.AddMedicalExaminationType(model);

                    return RedirectToAction("ShowAll", "MedicalExaminationType");
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