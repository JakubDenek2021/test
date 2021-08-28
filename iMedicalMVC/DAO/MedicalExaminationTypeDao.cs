using iMedicalMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iMedicalMVC.DAO
{
    public class MedicalExaminationTypeDao
    {
        internal List<Medical_examination_type> GetAll()
        {

            using (var db = new iMedicalDbContext())
            {
                return db.Medical_examination_type.ToList();
            }

        }

        internal void Save(Medical_examination_type medicalExaminationType)
        {

            try
            {
                using (var db = new iMedicalDbContext())
                {
                    db.Medical_examination_type.Add(medicalExaminationType);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Wystapil blad podczas zapisu do bazy danych");
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

    }
}