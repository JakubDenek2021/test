using iMedicalMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iMedicalMVC.DAO
{
    public class TitleTypeDao
    {
        internal List<Title_Type> GetAll()
        {

            using (var db = new iMedicalDbContext())
            {
                return db.Title_Type.ToList();
            }

        }

        internal void Save(Title_Type titleType)
        {

            try
            {
                using (var db = new iMedicalDbContext())
                {
                    db.Title_Type.Add(titleType);
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