using iMedicalMVC.Enum;
using iMedicalMVC.Fascade;
using iMedicalMVC.Infrastructure;
using iMedicalMVC.ViewModel.Visit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iMedicalMVC.Controllers
{
    [AuthorizeEnum(UserType.Patient)]
    public class PatientController : Controller
    {
        // GET: Patient
       
        public ActionResult Index()
        {
            var loginId = new SessionContext().GetLoginId();
            var model = new ProfileService().GetPatientName(loginId);
            return View(model);
        }


        [HttpGet]
        public ActionResult ShowProfile()
        {
            var loginId = new SessionContext().GetLoginId();
            var model = new AccountService().GetPatientProfile(loginId);
            return View(model);
        }

        [HttpGet]
        public ActionResult ShowAllVisit()
        {
            var loginId = new SessionContext().GetLoginId();
            var showAllVisit = new EmployeeService().GetAllPatientVisit(loginId);

            return View(showAllVisit);
        }

        [HttpGet]
        public ActionResult ShowAllMedicalExamination()
        {
            var loginId = new SessionContext().GetLoginId();
            var showAllVisit = new EmployeeService().GetAllPrescriptionPatient(loginId);

            return View(showAllVisit);
        }


        [HttpGet]
        public ActionResult ShowAllPrescription()
        {
            var loginId = new SessionContext().GetLoginId();
            var showAllVisit = new EmployeeService().GetAllPrescriptionPatient(loginId);

            return View(showAllVisit);
        }

        [HttpGet]
        public ActionResult ShowAllReferral()
        {
            var loginId = new SessionContext().GetLoginId();
            var showAllVisit = new EmployeeService().GetAllRefferalPatient(loginId);

            return View(showAllVisit);
        }

       

        [HttpGet]
        public ActionResult ShowRefferalDetails(int referralId)
        {
            // wyświetlanie szczegółów spedytorowi
            var model = new EmployeeService().GetDetailsRefferal(referralId);
            return View(model);
        }

        [HttpGet]
        public ActionResult ShowPrescriptionDetails(int prescriptionlId)
        {
            // wyświetlanie szczegółów spedytorowi
            var model = new EmployeeService().GetDetailsPrescription(prescriptionlId);
            return View(model);
        }

        [HttpGet]
        public ActionResult ShowVisitDetails(int visitlId)
        {
            // wyświetlanie szczegółów spedytorowi
            var model = new EmployeeService().GetDetailsVisit(visitlId);
            return View(model);
        }


    }
}