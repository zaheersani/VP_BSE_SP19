using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppDBFirst.Models
{
    public class AppointmentMetaData
    {
        [Display(Name = "Doctor")]
        public Nullable<int> doctorID { get; set; }

        [Display(Name = "Patient")]
        public Nullable<int> patentID { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public Nullable<System.DateTime> AppointmentDate { get; set; }

        [DataType(DataType.Time)]
        public Nullable<System.TimeSpan> AppointmentTime { get; set; }
    }

    [MetadataType(typeof(AppointmentMetaData))]
    public partial class Appointment
    {

    }
}