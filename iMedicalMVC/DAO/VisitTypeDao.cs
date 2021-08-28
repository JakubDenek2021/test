using iMedicalMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iMedicalMVC.DAO
{
    public class VisitTypeDao
    {
        internal List<Visit_type> GetAll()
        {

            using (var db = new iMedicalDbContext())
            {
                return db.Visit_type.ToList();
            }

        }

        internal void Save(Visit_type contract)
        {

            try
            {
                using (var db = new iMedicalDbContext())
                {
                    db.Visit_type.Add(contract);
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