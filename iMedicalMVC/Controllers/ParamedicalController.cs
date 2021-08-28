using iMedicalMVC.Enum;
using iMedicalMVC.Fascade;
using iMedicalMVC.Infrastructure;
using iMedicalMVC.ViewModel.Account;
using iMedicalMVC.ViewModel.Doctor;
using iMedicalMVC.ViewModel.Employee;
using iMedicalMVC.ViewModel.Login;
using iMedicalMVC.ViewModel.Visit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iMedicalMVC.Controllers
{
    [AuthorizeEnum(UserType.Paramedical)]
    public class ParamedicalController : Controller
    {
       
        [HttpGet]
        [AuthorizeEnum(UserType.Paramedical)]
        // GET: Paramedical
        public ActionResult Index()
        {
            var loginId = new SessionContext().GetLoginId();
            var model = new ProfileService().GetEmployeeName(loginId);
            return View(model);
        }

        [HttpGet]
        public ActionResult ShowAllPatient()
        {
            var showAllPatient = new PatientService().GetAll();

            return View(showAllPatient);
        }

        [HttpGet]
        public ActionResult ShowAllVisit()
        {
            var showAllVisit = new EmployeeService().GetAllVisit();

            return View(showAllVisit);
        }

        [HttpGet]
        public ActionResult ShowAllMedicalExamination()
        {
            var showAllVisit = new EmployeeService().GetAllMedicalExamination();

            return View(showAllVisit);
        }


        [HttpGet]
        public ActionResult RegistrationNewPatient()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegistrationNewPatient(RegistrationViewModel model)
        {
            if (ModelState.IsValid)
            {
                var registrationService = new RegistrationService();
                try
                {
                    registrationService.Validate(model);
                    registrationService.Save(model);
                    ViewBag.Message = "Zalozono konto";
                    return RedirectToAction("ShowAllPatient", "Paramedical");
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
        //            return RedirectToAction("ShowAllVisit", "Paramedical");
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

        [HttpGet]
        public ActionResult AddNewMedicalExaminationDetails()
        {

            var medicalExaminationList = new SelectList(new PatientService().GetAllMedicalExaminationlist(), "Id", "NumberPatient ");


            var model = new CreateMedicDetailsViewModel()
            {

                MedicalExaminationList = medicalExaminationList


            };
            return View(model);
        }
        [HttpPost]
        public ActionResult AddNewMedicalExaminationDetails(CreateMedicDetailsViewModel model)
        {
            if (ModelState.IsValid)
            {
                var visitService = new EmployeeService();
                try
                {
                    visitService.ValidateNewMedicalExaminationDetails(model);
                    visitService.SaveMedicalExaminationDetails(model);
                    return RedirectToAction("ShowAllMedicalExamination", "Paramedical");
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
        public ActionResult AddNewMedicalExamination()
        {

            var patientList = new SelectList(new PatientService().GetAllPatientlist(), "Id", "NumberPatient ");
            var medicalExaminationTypeList = new SelectList(new EmployeeService().GetAllMedicalExaminationTypelist(), "ID", "Name");

            var model = new CreateMedicalExaminationViewModel()
            {

                PatientList = patientList,
                MedicalExaminationList = medicalExaminationTypeList


            };
            return View(model);
        }

        [HttpPost]
        public ActionResult AddNewMedicalExamination(CreateMedicalExaminationViewModel model)
        {
            if (ModelState.IsValid)
            {
                var visitService = new EmployeeService();
                try
                {
                    visitService.ValidateNewMedicalExamination(model);
                    visitService.SaveMedicalExamination(model);
                    return RedirectToAction("ShowAllMedicalExamination", "Paramedical");
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
        public ActionResult AddNewVisit()
        {

            var typeEmployeeList = new SelectList(new EmployeeService().GetAllEmployeeDoctorlist(), "Id", "NumberEmployee ");
            var patientList = new SelectList(new PatientService().GetAllPatientlist(), "Id", "NumberPatient ");
            var visitTypeList = new SelectList(new EmployeeService().GetAllVisitTypelist(), "ID", "Name");

            var model = new CreateNewVistViewModel()
            {

                EmployeeList = typeEmployeeList,
                PatientList = patientList,
                VisitTypeList = visitTypeList,
      

            };
            return View(model);
        }


        [HttpPost]
        public ActionResult AddNewVisit(CreateNewVistViewModel model)
        {
            if (ModelState.IsValid)
            {
                var visitService = new EmployeeService();
                try
                {
                    visitService.ValidateNewVisit(model);
                    visitService.SaveVisit(model);
                    return RedirectToAction("ShowAllVisit", "Paramedical");
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


                    return RedirectToAction("Index", "Paramedical");
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
