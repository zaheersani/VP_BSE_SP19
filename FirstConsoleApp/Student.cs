using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class Student
    {
        private string fname;
        private string lname;
        private string regno;

        public Student() { }

        public string FirstName
        {
            get { return this.fname; }
            set { this.fname = value; }
        }

        public string LastName
        {
            get { return this.lname; }
            set { this.lname = value; }
        }

        public Student(string FirstName, string LastName, string RegNo)
        {
            this.fname = FirstName;
            this.lname = LastName;
            this.regno = RegNo;
        }
    }

    class Employee
    {
        public string Name { get; private set; }
        public string Designation { get; set; }
        public string Department { get; set; }

        public Employee(string Name)
        {
            this.Name = Name;
        }
    }
}
