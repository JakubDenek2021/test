using iMedicalMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iMedicalMVC.DAO
{
    public class ContractTypeDao
    {
        internal List<Contract_Type> GetAll()
        {

            using (var db = new iMedicalDbContext())
            {
                return db.Contract_Type.ToList();
            }

        }
        internal void Save(Contract_Type contract_Type)
        {

            try
            {
                using (var db = new iMedicalDbContext())
                {
                    db.Contract_Type.Add(contract_Type);
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