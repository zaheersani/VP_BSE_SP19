using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class FYP
    {
        public int ID { get; set; }

        public string Title { get; set; }
        public int Members { get; set; }
        public string Description { get; set; }

        public int SupervisorID { get; set; }
        public Supervisor supervisorObj { get; set; }
    }

    public class Supervisor
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Faculty Name must be entered!")]
        [Display(Name = "Faculty Member")]
        public string Name { get; set; }

        public string Designation { get; set; }

        [Range(0, 10, ErrorMessage = "Specify Projects between 0 and 10")]
        public int Projects { get; set; }
    }

    public class FacultyCourse
    {
        public int ID { get; set; }

        public int SupervisorID { get; set; }
        public int CourseID { get; set; }

        public Supervisor supervisorObj { get; set; }
        public Course courseObj { get; set; }
    }

    public class Course
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
    }

    public class FYPView
    {
        public string Project { get; set; }
        public string Supervisor { get; set; }
    }
}