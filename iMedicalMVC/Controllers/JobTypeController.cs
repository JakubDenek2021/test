using iMedicalMVC.Fascade;
using iMedicalMVC.ViewModel.ContractType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iMedicalMVC.Controllers
{
    public class JobTypeController : Controller
    {
        [HttpGet]
        public ActionResult ShowAll()
        {
            var showAllJobType = new JobTypeService().GetAll();

            return View(showAllJobType);
        }

        [HttpGet]
        public ActionResult AddNew()
        {
            return View();
        }



        [HttpPost]
        public ActionResult AddNew(CreateJobTypeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var jobTypeService = new JobTypeService();
                try
                {
                    jobTypeService.ValidateJobType(model);
                    jobTypeService.AddJobType(model);

                    return RedirectToAction("ShowAll", "JobType");
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