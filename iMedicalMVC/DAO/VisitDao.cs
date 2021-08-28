using iMedicalMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iMedicalMVC.DAO
{
    public class VisitDao
    {
        internal List<Visit> GetAllVisitlist()
        {
            using (var db = new iMedicalDbContext())
            {
                var model = db.Visit.ToList();
                return model;
            }

        }
    }
}