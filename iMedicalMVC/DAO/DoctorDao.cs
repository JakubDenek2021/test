using iMedicalMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace iMedicalMVC.DAO
{
    public class DoctorDao
    {
      
        
        internal List<Employee> GetAllDoctorList()
        {

            using (var db = new iMedicalDbContext())
            {
                return db.Employee.ToList();
            }

        }


        internal void SaveReferral(Referral doctor)
        {
            using (var db = new iMedicalDbContext())
            {
                using (var medi = db.Database.BeginTransaction())
                {

                    Random generator = new Random();

                    db.Referral.Add(doctor);
                    db.SaveChanges();
                    doctor.Issue_Date = DateTime.Now;
                    int v = generator.Next(10000);
                    int v2 = generator.Next(1000);
                    doctor.ReferralCod = v;
                    doctor.Referral_number = DateTime.Now.Year + "/" + v2 + "/" + v2 + "/" + DateTime.Now.Month;
                    db.SaveChanges();
                    medi.Commit();
                }




            }


        }

        internal void SaveVisit(Visit doctor)
        {
            using (var db = new iMedicalDbContext())
            {


                db.Visit.Add(doctor);
                db.SaveChanges();





            }
            //internal void SaveNewVisit(Visit_Details visitDetails)
            //{

            //    using (var db = new iMedicalDbContext())
            //    {




            //            db.Visit_Details.Add(visitDetails);
            //            db.SaveChanges();

            //    }
            //}


        }
    }
}