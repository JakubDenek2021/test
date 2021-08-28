using iMedicalMVC.Fascade;
using iMedicalMVC.ViewModel.ContractType;
using iMedicalMVC.ViewModel.Specialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iMedicalMVC.Controllers
{
    public class SpecializationController : Controller
    {
        //    [HttpGet]
        //    public ActionResult ShowAll()
        //    {
        //        var showAllSpecialization = new SpecializationTypeService().GetAll();

        //        return View(showAllSpecialization);
        //    }

        //    [HttpGet]
        //    public ActionResult AddNew()
        //    {
        //        return View();
        //    }



        //    [HttpPost]
        //    public ActionResult AddNew(CreateSpecializationViewModel model)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            var specializationService = new SpecializationTypeService();
        //            try
        //            {
        //                specializationService.ValidateSpecialization(model);
        //                specializationService.AddSpecialization(model);

        //                return RedirectToAction("ShowAll", "Specialization");
        //            }
        //            catch (Exception e)
        //            {
        //                ModelState.AddModelError(string.Empty, e.Message);
        //                return View(model);
        //            }
        //        }
        //        else
        //        {
        //            return View(model);
        //        }
        //}
    }

    
}