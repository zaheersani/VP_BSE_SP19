using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class FYP
    {
        public string Title { get; set; }
        public int Members { get; set; }
        public string Description { get; set; }
    }

    public class Supervisor
    {
        public string Name { get; set; }
        public string Designation { get; set; }
    }

    public class FYPView
    {
        public string Project { get; set; }
        public string Supervisor { get; set; }
    }
}