using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace iMedicalMVC.ViewModel.Patient
{
    public class ShowDetailsVisitViewModel
    {
        public int VisitId { get; set; }

        public string Comments { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DateStart { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DateReservation { get; set; }

        public string VisitNumber { get; set; }

        public string ActivitesPerfomed { get; set; }

        public string Recomendations { get; set; }

        public string GeneralInformation { get; set; }

        public string DosageOfMedication { get; set; }


    }
}