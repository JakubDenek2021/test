using iMedicalMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iMedicalMVC.DAO
{
    public class ProfileDao
    {
        internal Patient GetPatient(int loginId)
        {
            using (var db = new iMedicalDbContext())
            {
                return db.Patient.Where(s => s.ID_Login == loginId).Single();
            }
        }

        internal Employee GetEmployee(int loginId)
        {
            using (var db = new iMedicalDbContext())
            {
                return db.Employee.Where(s => s.ID_Login == loginId).Single();
            }
        }

        internal Contract GetContractDetails(int serviceId)
        {
            using (var db = new iMedicalDbContext())
            {
                var model1 = db.Contract.Include("Employee").ToList();
                var model2 = db.Contract.Include("Job_Type").ToList();

                var model4 = db.Contract.Include("Contract_Type").ToList();
                var model3 = db.Contract.Include("Tenure_Type").ToList();
                return db.Contract.Where(s => s.ID_Contract == serviceId).Single();
            }
        }
    }
}