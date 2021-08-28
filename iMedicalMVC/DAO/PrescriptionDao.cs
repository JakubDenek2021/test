using iMedicalMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iMedicalMVC.DAO
{
    public class PrescriptionDao
    {
         
    internal void SavePrescription(Prescription prescription)
        {

            using (var db = new iMedicalDbContext())
            {
                using (var medi = db.Database.BeginTransaction())
                {

                    Random generator = new Random();

                    db.Prescription.Add(prescription);
                    db.SaveChanges();
                    prescription.IssueDate = DateTime.Now;
                    int v = generator.Next(10000);
                   int v2 = generator.Next(1000);
                   prescription.PrescriptionCode = v;
                   prescription.NumberPrescription = DateTime.Now.Year + "/" + v2 + "/" + v2 +"/";
                    db.SaveChanges();
                    medi.Commit();
                }
                
               


            }
        }
    }
}