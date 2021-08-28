using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using iMedicalMVC.Models;

namespace iMedicalMVC.DAO
{
    public class LoginDao
    {
        public bool CheckPassword(string login, string Hash)
        {
            using (var db = new iMedicalDbContext())
            {
                return db.Login.Where(s => s.Login1 == login && s.Password == Hash).Any();
            }
        }

        internal int GetLoginId(string login)
        {
            using (var db = new iMedicalDbContext())
            {
                return db.Login.Where(s => s.Login1 == login).Select(s => s.ID_Login).Single();
            }
        }

        public int GetIdClient(int idLogin)
        {
            using (var db = new iMedicalDbContext())
            {

                return db.Patient.Where(s => s.ID_Login == idLogin).Select(s => s.ID_Patient).Single();

            }
        }



        internal string GetLogin(int idLogin)
        {
            using (var db = new iMedicalDbContext())
            {

                return db.Login.Where(s => s.ID_Login == idLogin).Select(s => s.Login1).Single();

            }
        }

        public int? GetEmployeeType(int idLogin)
        {
            using (var db = new iMedicalDbContext())
            {
                // var x = db.Employee.Where(s => s.Login.IdLogin == idLogin).FirstOrDefault();
                //  var y =  x.IdEmployeeType;
                return db.Employee.Where(s => s.Login.ID_Login == idLogin).Select(s => s.ID_EmployeeType).SingleOrDefault();
            }
        }

        internal void ChangePassword(string login, string v)
        {
            using (var db = new iMedicalDbContext())
            {
                try
                {
                    db.Login.Where(s => s.Login1 == login).Single().Password = v;
                    db.SaveChanges();
                }
                catch (Exception e)
                {

                    throw new Exception("Wystąpił błąd podczas zapisu do bazy danych");
                }
            }
        }
    }
}