using iMedicalMVC.Fascade;
using iMedicalMVC.ViewModel.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iMedicalMVC.Controllers
{
    public class RegistrationController : Controller
    {
        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration(RegistrationViewModel model)
        {
            if (ModelState.IsValid)
            {
                var registrationService = new RegistrationService();
                try
                {
                    registrationService.Validate(model);
                    registrationService.Save(model);
                    ViewBag.Message = "Zalozono konto";
                    return RedirectToAction("Success", "Account");
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