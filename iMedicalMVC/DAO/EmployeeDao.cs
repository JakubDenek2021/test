using iMedicalMVC.Enum;
using iMedicalMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace iMedicalMVC.DAO
{
    public class MedicalFaclityDao
    {

        internal void Update(Visit model)
        {
            using (var db = new iMedicalDbContext())
            {
                db.Visit.AddOrUpdate(model);
                db.SaveChanges();
            }
        }
        internal void SaveMedicalExaminationDetails(Medic_details examination)
        {
            using (var db = new iMedicalDbContext())
            {

                using (var medi = db.Database.BeginTransaction())
                {

                    Random generator = new Random();

                    db.Medic_details.Add(examination);
                    db.SaveChanges();
                    examination.Date = DateTime.Now;

                    db.SaveChanges();
                    medi.Commit();
                }

            }

        }
            internal void SaveMedicalExamination(Medical_examination examination)
        {
            using (var db = new iMedicalDbContext())
            {

                using (var medi = db.Database.BeginTransaction())
                {

                    Random generator = new Random();

                    db.Medical_examination.Add(examination);
                    db.SaveChanges();
                    int v2 = generator.Next(1000);
                    examination.NumberMedicalExamination = DateTime.Now.Year + "/" + v2 + "/" + v2 + "/" + DateTime.Now.Month;
                    db.SaveChanges();
                    medi.Commit();
                }

            }




       }

            internal void SaveVisit(Visit visit)
        {
            using (var db = new iMedicalDbContext())
            {
                using (var medi = db.Database.BeginTransaction())
                {

                    Random generator = new Random();

                    db.Visit.Add(visit);
                    db.SaveChanges();
                    visit.Registration_date = DateTime.Now;
                    int v2 = generator.Next(1000);
                    visit.VisitNumber = DateTime.Now.Year + "/" + v2 + "/" + v2 + "/" + DateTime.Now.Month;
                    db.SaveChanges();
                    medi.Commit();
                }




            }
        }
        internal List<Employee> GetAllAdministration()
        {
            using (var db = new iMedicalDbContext())
            {


                return db.Employee.Where(s => s.ID_EmployeeType == 3).ToList();
            }
        }
        internal List<Employee> GetAllParamedical()
        {
            using (var db = new iMedicalDbContext())
            {


                return db.Employee.Where(s => s.ID_EmployeeType == 1).ToList();
            }
        }
        internal List<Employee> GetAllDoctor()
        {
            using (var db = new iMedicalDbContext())
            {


                return db.Employee.Where(s => s.ID_EmployeeType == 2).ToList();
            }
        }
        internal List<Employee> GetAllEmployee()
        {
            using (var db = new iMedicalDbContext())
            {
                var model = db.Employee.Include("EmployeeType").ToList();

                return db.Employee.ToList();
            }
        }

        internal List<Employee_Type> GetAll()
        {
            using (var db = new iMedicalDbContext())
            {
                var model = db.Employee_Type.ToList();
                return model;
            }

        }

        internal List<Title_Type> GetAllTitleType()
        {
            using (var db = new iMedicalDbContext())
            {
                var model = db.Title_Type.ToList();
                return model;
            }

        }


        internal List<Employee> GetAllEmployeelist()
        {
            using (var db = new iMedicalDbContext())
            {
                var model = db.Employee.ToList();
                return model;
            }

        }
        internal List<Payment_Details> GetAllPaymentDetailslist()
        {
            using (var db = new iMedicalDbContext())
            {
                var model = db.Payment_Details.ToList();
                return model;
            }

        }
        internal List<Employee> GetAllEmployeeDoctorlist()
        {
            using (var db = new iMedicalDbContext())
            {
                var model = db.Employee.Where(s => s.Employee_Type.ID_EmployeeType == (byte)UserType.Doctor).ToList();
                return model;
            }

        }
        internal List<Contract> GetAllContractlist()
        {
            using (var db = new iMedicalDbContext())
            {
                var model = db.Contract.ToList();
                return model;
            }

        }
        internal List<Billing_tenure> GetAllBillinglist()
        {
            using (var db = new iMedicalDbContext())
            {
                var model = db.Billing_tenure.ToList();
                return model;
            }

        }
        internal List<Job_Type> GetAllJobTypelist()
        {
            using (var db = new iMedicalDbContext())
            {
                var model = db.Job_Type.ToList();
                return model;
            }

        }

        internal List<Tenure_type> GetAllTenureTypelist()
        {
            using (var db = new iMedicalDbContext())
            {
                var model = db.Tenure_type.ToList();
                return model;
            }

        }

        internal List<Visit_type> GetAllVisitTypelist()
        {
            using (var db = new iMedicalDbContext())
            {
                var model = db.Visit_type.ToList();
                return model;
            }

        }

        internal List<Billing_tenure> GetAllBillingTenure()
        {
            using (var db = new iMedicalDbContext())
            {
                var model = db.Billing_tenure.ToList();
                return model;
            }

        }
        internal List<Medical_examination_type> GetAllMedicalExaminationTypelist()
        {
            using (var db = new iMedicalDbContext())
            {
                var model = db.Medical_examination_type.ToList();
                return model;
            }

        }

        internal List<Contract_Type> GetAllContractTypelist()
        {
            using (var db = new iMedicalDbContext())
            {
                var model = db.Contract_Type.ToList();
                return model;
            }

        }

        internal void Save(Employee employee)
        {
            try
            {
                using (var db = new iMedicalDbContext())
                {

                    employee.Number_Employee = "PLPR263" + 1;
                    db.Employee.Add(employee);
                    db.SaveChanges();

                }
            }
            catch (Exception e)
            {
                throw new Exception("Wystapil blad podczas zapisu do bazy danych");
            }
        }

        internal void SaveBilling(Billing_tenure billing)
        {
            try
            {
                using (var db = new iMedicalDbContext())
                {

                    billing.NumberBilling = "PL" + DateTime.Now.Year + "/" + DateTime.Now.Month + "/00" + 1;
                    billing.Insertion_date = DateTime.Now;
                    db.Billing_tenure.Add(billing);
                    db.SaveChanges();

                }
            }
            catch (Exception e)
            {
                throw new Exception("Wystapil blad podczas zapisu do bazy danych");
            }
        }
        internal void SavePaymantDetails(Payment_Details billing)
        {
            try
            {
                using (var db = new iMedicalDbContext())
                {
                    using (var medi = db.Database.BeginTransaction())
                    {

                        Random generator = new Random();

                        db.Payment_Details.Add(billing);
                        db.SaveChanges();
                        int v2 = generator.Next(1000);
                        int v = generator.Next(1000);
                        billing.PaymentDetailsNumber = DateTime.Now.Year + "/" + v2 + "/" + v + "/" + DateTime.Now.Month;
                        db.SaveChanges();
                        medi.Commit();
                    }

                  

                }
            }
            catch (Exception e)
            {
                throw new Exception("Wystapil blad podczas zapisu do bazy danych");
            }
        }


        internal void SaveContract(Contract contract)
        {
            using (var db = new iMedicalDbContext())
            {
                using (var trans = db.Database.BeginTransaction())
                {

                    db.Contract.Add(contract);
                    db.SaveChanges();
                    contract.NumberContract = DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + 1;
                    db.SaveChanges();
                    trans.Commit();
                }
            }
        }
      


        internal List<Contract> AllContract()
        {
            using (var db = new iMedicalDbContext())
            {
                var model = db.Contract.Include("Employee").ToList();

                return db.Contract.ToList();
            }
        }

        

        internal void Update(Employee modelDb)
        {
            using (var db = new iMedicalDbContext())
            {
                try
                {
                    db.Employee.AddOrUpdate(modelDb);
                    db.SaveChanges();
                }
                catch (Exception e)
                {

                    throw new Exception("Wystąpił błąd na zapisie do bazy danych");
                }
            }

        }


        internal Employee GetEmployee(int loginId)
        {
            using (var db = new iMedicalDbContext())
            {
                return db.Employee.Where(s => s.ID_Employee == loginId).Single();
            }
        }
        internal Visit GetVisit(int visitId)
        {
            using (var db = new iMedicalDbContext())
            {
                return db.Visit.Where(s => s.ID_Visit == visitId).Single();
            }
        }
    }



}




       

