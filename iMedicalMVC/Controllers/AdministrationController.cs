using iMedicalMVC.Enum;
using iMedicalMVC.Fascade;
using iMedicalMVC.Infrastructure;
using iMedicalMVC.ViewModel.Account;
using iMedicalMVC.ViewModel.Employee;
using iMedicalMVC.ViewModel.Login;
using iMedicalMVC.ViewModel.MedicalFacility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace iMedicalMVC.Controllers
{
    [AuthorizeEnum(UserType.Administration)]
    public class AdministrationController : Controller
    {
        // GET: Administration
        public ActionResult Index()
        {
            var loginId = new SessionContext().GetLoginId();
            var model = new ProfileService().GetEmployeeName(loginId);
            return View(model);
        }

        [HttpGet]
        public ActionResult AddNewEmployee()
        {
            var employeeList = new SelectList(new EmployeeService().GetAllEmployeeList(), "Id", "Name");
           
            var model = new RegistrationEmployeeViewModel()
            {

                EmployeeList = employeeList,
            };
            return View(model);
        }

       

       
       
       
        [HttpPost]
        public ActionResult AddNewEmployee(RegistrationEmployeeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var registrationService = new EmployeeService();
                try
                {
                    registrationService.ValidateNewEmployee(model);
                    registrationService.SaveNewEmployee(model);
                    ViewBag.Message = "Zalozono konto";
                    return RedirectToAction("ShowAllEmployee", "Administration");
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
        public ActionResult ShowAllEmployee()
        {
            var showAllEmployee = new EmployeeService().GetAllEmployee();

            return View(showAllEmployee);
        }

        [HttpGet]
        public ActionResult ShowAllPaymentDetails()
        {
            var showAllEmployee = new EmployeeService().GetAllPaymentDetails();

            return View(showAllEmployee);
        }

        public ActionResult Dictionary()
        {
            return View();
        }

       
            
        

      

        [HttpGet]
        public ActionResult ShowAllDoctor()
        {
            var showAllDoctor = new EmployeeService().GetAllDoctor();

            return View(showAllDoctor);
        }

        [HttpGet]
        public ActionResult ShowAllParamedical()
        {
            var showAllParamedical = new EmployeeService().GetAllParamedical();

            return View(showAllParamedical);
        }

        [HttpGet]
        public ActionResult ShowAllAdministration()
        {
            var showAllParamedical = new EmployeeService().GetAllAdministration();

            return View(showAllParamedical);
        }

        [HttpGet]
        public ActionResult AddNewContract()
        {

            var typeEmployeeList = new SelectList(new EmployeeService().GetAllEmployeeDoctorlist(), "Id", "NumberEmployee ");
            var typeJobTypeList = new SelectList(new EmployeeService().GetAllJobTypelist(), "ID", "Name");
            var typeTenureTypeList = new SelectList(new EmployeeService().GetAllTenureTypelist(), "ID", "Name");
            var typeContractTypeList = new SelectList(new EmployeeService().GetAllContractTypelist(), "ID", "Name");
            var model = new CreateNewContractViewModel()
            {

                EmployeeList = typeEmployeeList,
                JobTypeList = typeJobTypeList,
                TenureTypeList = typeTenureTypeList,
                ContracTypeList = typeContractTypeList,

            };
            return View(model);
        }

        [HttpPost]
        public ActionResult AddNewContract(CreateNewContractViewModel model)
        {
            if (ModelState.IsValid)
            {
                var employeeService = new EmployeeService();
                try
                {
                    employeeService.ValidateNewContract(model);
                    employeeService.SaveContract(model);
                    return RedirectToAction("ShowAllContract", "Administration");
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
        public ActionResult ShowAllContract()
        {
            var showAllContract = new EmployeeService().GetAllContract();

            return View(showAllContract);
        }

        [HttpGet]
        public ActionResult ShowAllBillingTenure()
        {
            var showAllContract = new EmployeeService().GetAllBillingTenure();

            return View(showAllContract);
        }

        [HttpGet]
        public ActionResult AddNewBilling()
        {

            var typeContractList = new SelectList(new EmployeeService().GetAllContractlist(), "Id", "Name");

            var model = new CreateNewBillingViewModel()
            {

                ContractList = typeContractList
         

            };
            return View(model);
        }

        [HttpPost]
        public ActionResult AddNewBilling(CreateNewBillingViewModel model)
        {
            if (ModelState.IsValid)
            {
                var employeeService = new EmployeeService();
                try
                {
                    employeeService.ValidateNewBilling(model);
                    employeeService.SaveBilling(model);
                    return RedirectToAction("ShowAllContract", "Administration");
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
        public ActionResult AddNewPaimentDetails()
        {

            var typeContractList = new SelectList(new EmployeeService().GetAllContractlist(), "Id", "Name");
            var typeBillingList = new SelectList(new EmployeeService().GetAllBillinglist(), "ID", "Name");
            var model = new CreateNewPaymantDetailsViewModel()
            {

                ContractList = typeContractList,
                BillingList = typeBillingList


            };
            return View(model);
        }

        [HttpPost]
        public ActionResult AddNewPaimentDetails(CreateNewPaymantDetailsViewModel model)
        {
            if (ModelState.IsValid)
            {
                var employeeService = new EmployeeService();
                try
                {
                    employeeService.ValidateNewPaymantDetails(model);
                    employeeService.SavePaymantDetails(model);
                    return RedirectToAction("ShowAllPaymentDetails", "Administration");
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
        public ActionResult ShowDetailsContract(int contractId)
        {
            // wyświetlanie szczegółów spedytorowi
            var model = new EmployeeService().GetDetailsContract(contractId);
            return View(model);
        }

    }

}