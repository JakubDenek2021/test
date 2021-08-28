using iMedicalMVC.DAO;
using iMedicalMVC.Helpers;
using iMedicalMVC.Models;

using iMedicalMVC.ViewModel.Employee;
using iMedicalMVC.ViewModel.Patient;
using iMedicalMVC.ViewModel.TitleType;
using iMedicalMVC.Views.Patient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iMedicalMVC.Fascade
{
    public class EmployeeService
    {
        public ShowDetailsContractViewModel GetDetailsContract(int serviceId)
        {
            var model = new ProfileDao().GetContractDetails(serviceId);

            var result = new ShowDetailsContractViewModel()
            {
                EmployeeId = model.ID_Employee,
                Name = model.Employee.FirstName,
                LastName = model.Employee.LastName,
                TenureTypeId = model.ID_Tenure_type,
                TenureName = model.Tenure_type.Name,
                ContractTypeId = model.ID_Contract_Type, 
                ContractTypName = model.Contract_Type.Name,
                JobTypeId = model.ID_Job_Type,
                JobTypeName = model.Job_Type.Name,
                Bonu = model.Bonus,
                HourlyRate = model.HourlyRate,
                MonthRate = model.MonthlyRate,
                NumberAccount = model.NumberAccount,
               ConclusionDate = model.ConclusionDate,
               NumberContract = model.NumberContract


            };
            return result;
        }
        public ShowDetailsVisitViewModel GetDetailsVisit(int prescriptionId)
        {
            var model = new PatientDao().GetVisitDetails(prescriptionId);

            var result = new ShowDetailsVisitViewModel()
            {
                VisitId = model.ID_Visit,
                DateReservation = model.Registration_date,
                Comments = model.Comments,
                DateStart = model.Date_hour_visit_start,
                VisitNumber = model.VisitNumber,
                ActivitesPerfomed = model.Activities_performed,
                Recomendations = model.Recomendations,
                GeneralInformation = model.General_information,
                DosageOfMedication = model.Dosage_of_medication
                





            };
            return result;
        }
        public ShowPrescriptionDetailsViewModel GetDetailsPrescription(int prescriptionId)
        {
            var model = new PatientDao().GetPrescriptionDetails(prescriptionId);

            var result = new ShowPrescriptionDetailsViewModel()
            {
                PrescriptionId = model.ID_Prescription,
                NumberPrescription = model.NumberPrescription,
                Medication_1 = model.Medication_1,
                Medication_2 = model.Medication_2,
                Medication_3 = model.Medication_3,
                Medication_4 = model.Medication_4,
                Medication_5 = model.Medication_5,
                Medication_6 = model.Medication_6,
                Medication_7 = model.Medication_7,
                Dose_1 = model.Dose_1,
                Dose_2 = model.Dose_2,
                Dose_3 = model.Dose_3,
                Dose_4 = model.Dose_4,
                Dose_5 = model.Dose_5,
                Dose_6 = model.Dose_6,
                Dose_7 = model.Dose_7,
                IssueDate = model.IssueDate,
                PrescriptionCode = model.PrescriptionCode
                




            };
            return result;
        }
        public ShowDetailsRefferalViewModel GetDetailsRefferal(int refferalId)
        {
            var model = new PatientDao().GetReferralDetails(refferalId);

            var result = new ShowDetailsRefferalViewModel()
            {
                ReferralId = model.ID_Referral,
                RefferalNumber = model.Referral_number,
                Issue_Date = model.Issue_Date,
                RefferalCode = model.ReferralCod,
                Description = model.Description
                



            };
            return result;
        }
        private List<ShowAllVisitViewModel> MapDoctor(List<Visit> allVisitList)
        {
            var result = new List<ShowAllVisitViewModel>();
            foreach (var item in allVisitList)
            {
                var model = new ShowAllVisitViewModel();

                model.IdVisit = item.ID_Visit;
                model.VisitNumber = item.VisitNumber;
                model.DateVisit = item.Date_hour_visit_start;
                model.RegistrationDate = item.Registration_date;

                result.Add(model);
            }
            return result;
        }
        public List<ShowAllVisitViewModel> GetAllDoctorVisit(int idLogin)
        {
            var orderList = new PatientDao().GetAllDoctorVisit(idLogin);
            return MapDoctor(orderList);
        }

        private List<ShowAllVisitViewModel> MapPatient(List<Visit> allVisitList)
        {
            var result = new List<ShowAllVisitViewModel>();
            foreach (var item in allVisitList)
            {
                var model = new ShowAllVisitViewModel();


                model.VisitNumber = item.VisitNumber;
                model.DateVisit = item.Date_hour_visit_start;
                model.RegistrationDate = item.Registration_date;

                result.Add(model);
            }
            return result;
        }
        public List<ShowAllVisitViewModel> GetAllPatientVisit(int idLogin)
        {
            var orderList = new PatientDao().GetAllPatientVisit(idLogin);
            return MapDoctor(orderList);
        }

        private List<ShowAllPrescriptionPatientViewModel> MapPatientPrescription(List<Prescription> allVisitList)
        {
            var result = new List<ShowAllPrescriptionPatientViewModel>();
            foreach (var item in allVisitList)
            {
                var model = new ShowAllPrescriptionPatientViewModel();

                model.PrescriptionId = item.ID_Prescription;
                model.NumberPrescription = item.NumberPrescription;
                model.IssueDate = item.IssueDate;
       
            

                result.Add(model);
            }
            return result;
        }
        public List<ShowAllPrescriptionPatientViewModel> GetAllPrescriptionPatient(int idLogin)
        {
            var orderList = new PatientDao().GetAllPrescriptionPatient(idLogin);
            return MapPatientPrescription(orderList);
        }



        private List<ShowAllRefferalPatientViewModel> MapPatientRefferal(List<Referral> allVisitList)
        {
            var result = new List<ShowAllRefferalPatientViewModel>();
            foreach (var item in allVisitList)
            {
                var model = new ShowAllRefferalPatientViewModel();
                model.ReferralId = item.ID_Referral;
                model.NumberRefferal = item.Referral_number;
                model.IssueDate = item.Issue_Date;



                result.Add(model);
            }
            return result;
        }
        public List<ShowAllRefferalPatientViewModel> GetAllRefferalPatient(int idLogin)
        {
            var orderList = new PatientDao().GetAllRefferalPatient(idLogin);
            return MapPatientRefferal(orderList);
        }












        private List<ShowAllMedicalExaminationPatientViewModel> MapPatientMedicalExamination(List<Medical_examination> allVisitList)
        {
            var result = new List<ShowAllMedicalExaminationPatientViewModel>();
            foreach (var item in allVisitList)
            {
                var model = new ShowAllMedicalExaminationPatientViewModel();

                model.NumberMedicalExamination = item.NumberMedicalExamination;
                model.IssueDate = item.IssueDate;


                result.Add(model);
            }
            return result;
        }
        public List<ShowAllMedicalExaminationPatientViewModel> GetAllMedicalExaminationPatient(int idLogin)
        {
            var orderList = new PatientDao().GetAllMedicalExaminationPatient(idLogin);
            return MapPatientMedicalExamination(orderList);
        }



        public List<ShowAllVisitViewModel> GetAllVisit()
        {
            var model = new PatientDao().GetAllVisit();
            var result = new List<ShowAllVisitViewModel>();
            foreach (var item in model)
            {
                result.Add(new ShowAllVisitViewModel()
                {
                    VisitNumber = item.VisitNumber,
                    DateVisit = item.Date_hour_visit_start,
                    RegistrationDate = item.Registration_date
               
                });
            }
            return result;
        }

        public List<ShowAllMedicalExaminationViewModel> GetAllMedicalExamination()
        {
            var model = new PatientDao().GetAllMedicalExamination();
            var result = new List<ShowAllMedicalExaminationViewModel>();
            foreach (var item in model)
            {
                result.Add(new ShowAllMedicalExaminationViewModel()
                {
                    IssueDate = item.IssueDate,
                    NumberMedicalExamination = item.NumberMedicalExamination

                });
            }
            return result;
        }
        public void SaveMedicalExaminationDetails(CreateMedicDetailsViewModel viewModel)
        {
            //VM -> Model
            Medic_details visit = new Medic_details();



            visit.ID_Medical_examination = viewModel.MedicalExaminationListId;
            visit.Result_1 = viewModel.Result1;
            visit.Result_2 = viewModel.Result2;
            visit.Result_3 = viewModel.Result3;
            visit.Result_4 = viewModel.Result4;
            visit.Recommendations = viewModel.Recommendations;

    

            //Wywolanie metody z dao ktora zapisze dane 
            new MedicalFaclityDao().SaveMedicalExaminationDetails(visit);
        }

        internal void ValidateNewMedicalExaminationDetails(CreateMedicDetailsViewModel model)
        {
            //throw new NotImplementedException();
        }
        public void SaveMedicalExamination(CreateMedicalExaminationViewModel viewModel)
        {
            //VM -> Model
            Medical_examination visit = new Medical_examination();

          
            visit.ID_Patient = viewModel.PatientListId;
            visit.ID_medical_examination_type = viewModel.MedicalExaminationListId;
            visit.NumberReferral = viewModel.NumberReferral;
            visit.IssueDate = viewModel.IssueDate;
           



            //Wywolanie metody z dao ktora zapisze dane 
            new MedicalFaclityDao().SaveMedicalExamination(visit);
        }

        internal void ValidateNewMedicalExamination(CreateMedicalExaminationViewModel model)
        {
            //throw new NotImplementedException();
        }

        public void SaveVisit(CreateNewVistViewModel viewModel)
        {
            //VM -> Model
            Visit visit = new Visit();

            visit.ID_Employee = viewModel.EmployeeListId;
            visit.ID_Patient = viewModel.PatientListId;
            visit.ID_Visit_type = viewModel.VisitTypeListId;
            visit.Comments = viewModel.Comments;
            visit.Date_hour_visit_start = viewModel.DateHourVisitStart;
       


            //Wywolanie metody z dao ktora zapisze dane 
            new MedicalFaclityDao().SaveVisit(visit);
        }

        internal void ValidateNewVisit(CreateNewVistViewModel model)
        {
            //throw new NotImplementedException();
        }
        public List<MedicalBranchListViewModel> GetAllEmployeeList()
        {
            var model = new MedicalFaclityDao().GetAll();
            var result = new List<MedicalBranchListViewModel>();
            foreach (var item in model)
            {
                result.Add(new MedicalBranchListViewModel()
                {
                    Id = item.ID_EmployeeType,
                    Name = item.Name,
                });
            }
            return result;
        }

        


        public List<EmployeeListViewModel> GetAllEmployeeDoctorlist()
        {
            var model = new MedicalFaclityDao().GetAllEmployeeDoctorlist();
            var result = new List<EmployeeListViewModel>();
            foreach (var item in model)
            {
                result.Add(new EmployeeListViewModel()
                {
                    ID = item.ID_Employee,
                    NumberEmployee = item.Number_Employee + " (" + item.FirstName + " " + item.LastName + ")"

                });
            }
            return result;
        }


        public List<EmployeeListViewModel> GetAllEmployeelist()
        {
            var model = new MedicalFaclityDao().GetAllEmployeelist();
            var result = new List<EmployeeListViewModel>();
            foreach (var item in model)
            {
                result.Add(new EmployeeListViewModel()
                {
                    ID = item.ID_Employee,
                    NumberEmployee = item.Number_Employee + " (" + item.FirstName + " " + item.LastName + ")"
                   
                });
            }
            return result;
        }

        public List<JobTypeListViewModel> GetAllJobTypelist()
        {
            var model = new MedicalFaclityDao().GetAllJobTypelist();
            var result = new List<JobTypeListViewModel>();
            foreach (var item in model)
            {
                result.Add(new JobTypeListViewModel()
                {
                    ID = item.ID_Job_Type,
                    Name= item.Name

                });
            }
            return result;
        }

        public List<TenureTypeListViewModel> GetAllTenureTypelist()
        {
            var model = new MedicalFaclityDao().GetAllTenureTypelist();
            var result = new List<TenureTypeListViewModel>();
            foreach (var item in model)
            {
                result.Add(new TenureTypeListViewModel()
                {
                    ID = item.ID_Tenure_type,
                    Name = item.Name

                });
            }
            return result;
        }

        public List<VisitTypeListViewModel> GetAllVisitTypelist()
        {
            var model = new MedicalFaclityDao().GetAllVisitTypelist();
            var result = new List<VisitTypeListViewModel>();
            foreach (var item in model)
            {
                result.Add(new VisitTypeListViewModel()
                {
                    ID = item.ID_Visit_type,
                    Name = item.Name

                });
            }
            return result;
        }

        public List<MedicalExaminationTypeListViewModel> GetAllMedicalExaminationTypelist()
        {
            var model = new MedicalFaclityDao().GetAllMedicalExaminationTypelist();
            var result = new List<MedicalExaminationTypeListViewModel>();
            foreach (var item in model)
            {
                result.Add(new MedicalExaminationTypeListViewModel()
                {
                    ID = item.ID_medical_examination_type,
                    Name = item.Name

                });
            }
            return result;
        }

        public List<ContractTypeListViewModel> GetAllContractTypelist()
        {
            var model = new MedicalFaclityDao().GetAllContractTypelist();
            var result = new List<ContractTypeListViewModel>();
            foreach (var item in model)
            {
                result.Add(new ContractTypeListViewModel()
                {
                    ID = item.ID_Contract_Type,
                    Name = item.Name

                });
            }
            return result;
        }

      

        public List<TitleTypeListViewModel> GetAllTitleTypeList()
        {
            var model = new MedicalFaclityDao().GetAllTitleType();
            var result = new List<TitleTypeListViewModel>();
            foreach (var item in model)
            {
                result.Add(new TitleTypeListViewModel()
                {
                    ID = item.ID_Tytle_type,
                    Name = item.Name,
                });
            }
            return result;
        }

        public void SaveNewEmployee(RegistrationEmployeeViewModel viewModel)
        {
            //VM -> Model
            Employee employee = new Employee();
            Login loginObject = new Login();

            employee.FirstName = viewModel.FirstName;
            employee.MiddleName = viewModel.MiddleName;
            employee.LastName = viewModel.LastName;
            employee.PESEL = viewModel.PESEL;
            employee.DateOfBirth = viewModel.DateOfBirth;
            employee.CountryRegistration = viewModel.CountryRegistration;
            employee.PostalCodeRegistration = viewModel.CountryRegistration;
            employee.CityRegistration = viewModel.CityRegistration;
            employee.StreetRegistration = viewModel.StreetRegistration;
            employee.BuildingNumberRegistration = viewModel.BuildingNumberRegistration;
            employee.HousingNumberRegistration = viewModel.HousingNumberRegistration;
            employee.CountryResidence = viewModel.CityResidence;
            employee.PostalCodeResidence = viewModel.PostalCodeResidence;
            employee.CityResidence = viewModel.CityResidence;
            employee.StreetResidence = viewModel.CityResidence;
            employee.HouseNumberResidence = viewModel.HouseNumberResidence;
            employee.BuildingNumberResidence = viewModel.BuildingNumberResidence;
            employee.Email = viewModel.Email;
            employee.Phone = viewModel.Phone;
            employee.ID_EmployeeType = viewModel.EmployeeType;
            loginObject.Login1 = viewModel.Login;

            loginObject.Password = SHAHelper.GenerateSHA512(viewModel.Password);
            employee.Login = loginObject;

            //Wywolanie metody z dao ktora zapisze dane 
            new MedicalFaclityDao().Save(employee);
        }

        internal void ValidateNewEmployee(RegistrationEmployeeViewModel model)
        {

        }
        public List<EmployeeViewModel> GetAllEmployee()
        {
            var model = new MedicalFaclityDao().GetAllEmployeelist();
            var result = new List<EmployeeViewModel>();
            foreach (var item in model)
            {
                result.Add(new EmployeeViewModel()
                {
                    EmployeeId = item.ID_Employee,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Email = item.Email,
                    CountryRegistration = item.CountryRegistration,
                    NumberEmployee = item.Number_Employee,


                });
            }
            return result;
        }
        public List<ShowAllPaymantDetailsViewModel> GetAllPaymentDetails()
        {
            var model = new MedicalFaclityDao().GetAllPaymentDetailslist();
            var result = new List<ShowAllPaymantDetailsViewModel>();
            foreach (var item in model)
            {
                result.Add(new ShowAllPaymantDetailsViewModel()
                {
                    PaymentDetailsNumber = item.PaymentDetailsNumber,
                    PaymentDueDate = item.Payment_due_date


                });
            }
            return result;
        }
        public List<EmployeeViewModel> GetAllDoctor()
        {
            var model = new MedicalFaclityDao().GetAllDoctor();
            var result = new List<EmployeeViewModel>();
            foreach (var item in model)
            {
                result.Add(new EmployeeViewModel()
                {
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Email = item.Email,
                    CountryRegistration = item.CountryRegistration,
                    NumberEmployee = item.Number_Employee,


                });
            }
            return result;
        }
        public List<EmployeeViewModel> GetAllParamedical()
        {
            var model = new MedicalFaclityDao().GetAllParamedical();
            var result = new List<EmployeeViewModel>();
            foreach (var item in model)
            {
                result.Add(new EmployeeViewModel()
                {
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Email = item.Email,
                    CountryRegistration = item.CountryRegistration,
                    NumberEmployee = item.Number_Employee,


                });
            }
            return result;
        }

        public List<EmployeeViewModel> GetAllAdministration()
        {
            var model = new MedicalFaclityDao().GetAllAdministration();
            var result = new List<EmployeeViewModel>();
            foreach (var item in model)
            {
                result.Add(new EmployeeViewModel()
                {
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Email = item.Email,
                    CountryRegistration = item.CountryRegistration,
                    NumberEmployee = item.Number_Employee,


                });
            }
            return result;
        }

       
      

        internal void ValidateNewParamedical(CreateParamedicalViewModel model)
        {

        }

        public void SaveContract(CreateNewContractViewModel viewModel)
        {
            //VM -> Model
            Contract contract = new Contract();

            contract.Bonus = viewModel.Bonu;
            contract.HourlyRate = viewModel.HourlyRate;
            contract.MonthlyRate = viewModel.MonthRate;
            contract.NumberAccount = viewModel.NumberAccount;
            contract.ConclusionDate = viewModel.ConclusionDate;
            contract.ID_Job_Type = viewModel.JobTypeListId;
            contract.ID_Tenure_type = viewModel.TenureTypeListId;
            contract.ID_Employee = viewModel.EmployeeListId;
            contract.ID_Contract_Type = viewModel.ContractTypeListId;

            

            //Wywolanie metody z dao ktora zapisze dane 
            new MedicalFaclityDao().SaveContract(contract);
        }

        internal void ValidateNewContract(CreateNewContractViewModel model)
        {

        }
        
             public List<ShowAllBillingTenureViewModel> GetAllBillingTenure()
        {
            var model = new MedicalFaclityDao().GetAllBillinglist();
            var result = new List<ShowAllBillingTenureViewModel>();
            foreach (var item in model)
            {
                result.Add(new ShowAllBillingTenureViewModel()
                {
                    NumberBilling = item.NumberBilling,
                    DateFrom = item.Date_from,
                    DateTo = item.Date_to,
                    InsertionDate = item.Insertion_date
              
                });

            }
            return result;
        }
        public List<ContractViewModel> GetAllContract()
        {
            var model = new MedicalFaclityDao().AllContract();
            var result = new List<ContractViewModel>();
            foreach (var item in model)
            {
                result.Add(new ContractViewModel()
                {
                    ContractId = item.ID_Contract,
                    EmployeNumber = item.Employee.Number_Employee,
                    CreateDate = (DateTime)item.ConclusionDate,
                    NumberContrat = item.NumberContract
                }); 
                
            }
            return result;
        }

        public List<ContractListViewModel> GetAllContractlist()
        {
            var model = new MedicalFaclityDao().GetAllContractlist();
            var result = new List<ContractListViewModel>();
            foreach (var item in model)
            {
                result.Add(new ContractListViewModel()
                {
                    ID = item.ID_Contract,
                    Name = item.NumberContract
                });
            }
            return result;
        }
        public List<BillingListViewModel> GetAllBillinglist()
        {
            var model = new MedicalFaclityDao().GetAllBillinglist();
            var result = new List<BillingListViewModel>();
            foreach (var item in model)
            {
                result.Add(new BillingListViewModel()
                {
                    ID = item.ID_Biling_tenure,
                    Name = item.NumberBilling
                });
            }
            return result;
        }

        public void SaveBilling(CreateNewBillingViewModel viewModel)
        {
            //VM -> Model
            Billing_tenure billing = new Billing_tenure();

            billing.Insertion_date = viewModel.Insertion_date;
            billing.Date_from = viewModel.Date_from;
            billing.Date_to = viewModel.Date_to;
            billing.Hours_number = viewModel.Hours_number;
            billing.hours_extra_number = viewModel.hours_extra_number;
            billing.Comments = viewModel.Comments;
            billing.Description = viewModel.Description;
            billing.treatments_paid = viewModel.treatments_paid;
            billing.treatments_reimbursed = viewModel.treatments_reimbursed;
            billing.visits_paid = viewModel.visits_paid;
            billing.visits_reimbursed = viewModel.visits_reimbursed;
            billing.ID_Contract = viewModel.ContractListId;


            //Wywolanie metody z dao ktora zapisze dane 
            new MedicalFaclityDao().SaveBilling(billing);
        }

        internal void ValidateNewBilling(CreateNewBillingViewModel model)
        {

        }
        public void SavePaymantDetails(CreateNewPaymantDetailsViewModel viewModel)
        {
            //VM -> Model
            Payment_Details payDetails = new Payment_Details();

            payDetails.Payment_date = viewModel.Payment_date;
            payDetails.Payment_due_date = viewModel.Payment_due_date;
            payDetails.Total  = viewModel.Total;
            payDetails.Title = viewModel.Title;
            payDetails.Comments = viewModel.Comments;
            payDetails.ID_Billing_tenure = viewModel.BillingListId;
            payDetails.ID_Contract = viewModel.ContractListId;


            //Wywolanie metody z dao ktora zapisze dane 
            new MedicalFaclityDao().SavePaymantDetails(payDetails);
        }

        internal void ValidateNewPaymantDetails(CreateNewPaymantDetailsViewModel model)
        {

        }
    }
}