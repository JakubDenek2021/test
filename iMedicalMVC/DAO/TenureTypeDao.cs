using iMedicalMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iMedicalMVC.DAO
{
    public class TenureTypeDao
    {
        internal List<Tenure_type> GetAll()
        {

            using (var db = new iMedicalDbContext())
            {
                return db.Tenure_type.ToList();
            }

        }

        internal void Save(Tenure_type tenureType)
        {

            try
            {
                using (var db = new iMedicalDbContext())
                {
                    db.Tenure_type.Add(tenureType);
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