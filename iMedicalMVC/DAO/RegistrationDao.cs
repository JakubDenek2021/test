using iMedicalMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iMedicalMVC.DAO
{
    public class RegistrationDao
    {
        internal void Save(Patient patient)
        {
            try
            {
                using (var db = new iMedicalDbContext())
                {
                    db.Patient.Add(patient);
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