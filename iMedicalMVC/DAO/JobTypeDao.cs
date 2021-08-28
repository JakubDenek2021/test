using iMedicalMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iMedicalMVC.DAO
{
    public class JobTypeDao
    {
        internal List<Job_Type> GetAll()
        {

            using (var db = new iMedicalDbContext())
            {
                return db.Job_Type.ToList();
            }

        }

        internal void Save(Job_Type jobType)
        {

            try
            {
                using (var db = new iMedicalDbContext())
                {
                    db.Job_Type.Add(jobType);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Wystapil blad podczas zapisu do bazy danych");
            }

        }


    }
}