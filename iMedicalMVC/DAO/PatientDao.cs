using iMedicalMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iMedicalMVC.DAO
{
    public class PatientDao
    {
        internal Visit GetVisitDetails(int prescriptionlId)
        {
            using (var db = new iMedicalDbContext())
            {
                return db.Visit.Where(s => s.ID_Visit == prescriptionlId).Single();
            }
        }
        internal Prescription GetPrescriptionDetails(int prescriptionlId)
        {
            using (var db = new iMedicalDbContext())
            {
                return db.Prescription.Where(s => s.ID_Prescription == prescriptionlId).Single();
            }
        }
        internal Referral GetReferralDetails(int referralId)
        {
            using (var db = new iMedicalDbContext())
            {
                return db.Referral.Where(s => s.ID_Referral == referralId).Single();
            }
        }
        public List<Visit> GetAllDoctorVisit(int idLogin)
        {
            using (var db = new iMedicalDbContext())
            {
                var model = db.Visit.Where(s => s.Employee.ID_Login== idLogin).ToList();
                return model;
            }
        }

        public List<Visit> GetAllPatientVisit(int idLogin)
        {
            using (var db = new iMedicalDbContext())
            {
                var model = db.Visit.Where(s => s.Patient.ID_Login == idLogin).ToList();
                return model;
            }
        }

        public List<Medical_examination> GetAllMedicalExaminationPatient(int idLogin)
        {
            using (var db = new iMedicalDbContext())
            {
                var model = db.Medical_examination.Where(s => s.Patient.ID_Login == idLogin).ToList();
                return model;
            }
        }

        public List<Prescription> GetAllPrescriptionPatient(int idLogin)
        {
            using (var db = new iMedicalDbContext())
            {
                var model = db.Prescription.Where(s => s.Patient.ID_Login == idLogin).ToList();
                return model;
            }
        }

        public List<Referral> GetAllRefferalPatient(int idLogin)
        {
            using (var db = new iMedicalDbContext())
            {
                var model = db.Referral.Where(s => s.Patient.ID_Login == idLogin).ToList();
                return model;
            }
        }

        internal List<Visit> GetAllVisit()
        {

            using (var db = new iMedicalDbContext())
            {
                return db.Visit.ToList();
            }

        }

        internal List<Medical_examination> GetAllMedicalExamination()
        {

            using (var db = new iMedicalDbContext())
            {
                return db.Medical_examination.ToList();
            }

        }
        internal List<Patient> GetAll()
        {

            using (var db = new iMedicalDbContext())
            {
                return db.Patient.ToList();
            }

        }

        internal List<Patient> GetAllPatientlist()
        {
            using (var db = new iMedicalDbContext())
            {
                var model = db.Patient.ToList();
                return model;
            }

        }

        internal List<Medical_examination> GetAllMedicalExaminationlist()
        {
            using (var db = new iMedicalDbContext())
            {
                var model = db.Medical_examination.ToList();
                return model;
            }

        }
    }
}