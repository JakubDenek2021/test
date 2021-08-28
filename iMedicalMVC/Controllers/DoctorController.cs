using iMedicalMVC.Enum;
using iMedicalMVC.Fascade;
using iMedicalMVC.Infrastructure;
using iMedicalMVC.Models;
using iMedicalMVC.ViewModel.Doctor;
using iMedicalMVC.ViewModel.Login;
using iMedicalMVC.ViewModel.Scheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iMedicalMVC.Controllers
{
    [AuthorizeEnum(UserType.Doctor)]
    public class DoctorController : Controller
    {
        [HttpGet]
        public ActionResult ShowAllVisit()
        {
            var loginId = new SessionContext().GetLoginId();
            var showAllVisit = new EmployeeService().GetAllDoctorVisit(loginId);

            return View(showAllVisit);
        }


        // GET: Doctor
        [HttpGet]
        [AuthorizeEnum(UserType.Doctor)]
        public ActionResult Index()
        {
            var loginId = new SessionContext().GetLoginId();
            var model = new ProfileService().GetEmployeeName(loginId);
            return View(model);
        }


        [HttpGet]
        public ActionResult ShowProfile()
        {
            var loginId = new SessionContext().GetLoginId();
            var model = new AccountService().GetEmployeeProfile(loginId);
            return View(model);
        }

        [HttpGet]
        public ActionResult EditProfile()
        {
            var loginId = new SessionContext().GetLoginId();
            var model = new ProfileService().GetEmployeeProfileToEdit(loginId);
            return View(model);
        }


        [HttpPost]
        public ActionResult EditProfile(EditProfileEmployeeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var profileService = new ProfileService();
                try
                {
                    profileService.Edit(model);


                    return RedirectToAction("ShowProfile", "Administration");
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


        [HttpGet]
        public ActionResult AddNewPrescription()
        {

            var numberVisitList = new SelectList(new VisitTypeService().GetAllVisitlist(), "Id", "NumberVisit");
            var patientList = new SelectList(new PatientService().GetAllPatientlist(), "Id", "NumberPatient ");

            var model = new AddNewPrescriptionViewModel()
            {

                VisitNumberList = numberVisitList,
                PatientList = patientList

            };
            return View(model);

        }

        //[HttpGet]
        //public ActionResult AddNewVisitDet()
        //{
        //    var numberVisitList = new SelectList(new VisitTypeService().GetAllVisitlist(), "Id", "NumberVisit");
        //    var model = new AddNewVisitDetailsViewModel()
        //    {

        //        VisitNumberList = numberVisitList

        //    };
        //    return View(model);

        //}


        //[HttpPost]
        //public ActionResult AddNewVisitDet(AddNewVisitDetailsViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var doctorService = new DoctorService();
        //        try
        //        {
        //            doctorService.ValidateNewVisit(model);
        //            doctorService.SaveNewVisit(model);
        //            return RedirectToAction("ShowAllVisit", "Doctor");
        //        }
        //        catch (Exception e)
        //        {
        //            ModelState.AddModelError(string.Empty, e.Message);
        //            return View(model);
        //        }
        //    }
        //    else
        //    {
        //        return View(model);
        //    }
        //}
       


        [HttpPost]
        public ActionResult AddNewPrescription(AddNewPrescriptionViewModel model)
        {
            if (ModelState.IsValid)
            {
                var prescriptionService = new PrescriptionService();
                try
                {
                    prescriptionService.ValidateNewPrescription(model);
                    prescriptionService.SavePrescription(model);
                    return RedirectToAction("ShowAllVisit", "Doctor");
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


        [HttpGet]
        public ActionResult AddNewRef()
        {
            var patientList = new SelectList(new PatientService().GetAllPatientlist(), "Id", "NumberPatient ");
            var medicalExaminationList = new SelectList(new MedicalExaminationTypeService().GetAllMedicalExaminationTypelist(), "Id", "Name ");
            var model = new CreateNewReferralViewModel()
            {

                PatientList = patientList,
                MedicalExaminationTypeList = medicalExaminationList


            };
            return View(model);

        }



        [HttpPost]
        public ActionResult AddNewRef(CreateNewReferralViewModel model)
        {
            if (ModelState.IsValid)
            {
                var doctorService = new DoctorService();
                try
                {
                    // doctorService.ValidateNewDoctor(model);
                    doctorService.SaveReferral(model);
                    return RedirectToAction("ShowAllVisit", "Doctor");
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

        [HttpGet]
        public ActionResult EditVisit(int visitId)
        {

            var model = new ProfileService().GetVisitToEdit(visitId);
            return View(model);
        }

        [HttpPost]
        public ActionResult EditVisit(AddNewVisitDetailsViewModel model)
        {
            if (ModelState.IsValid)
            {
                var profileService = new ProfileService();
                try
                {
                    profileService.EditVisit(model);


                    return RedirectToAction("ShowAllVisit", "Doctor");
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



