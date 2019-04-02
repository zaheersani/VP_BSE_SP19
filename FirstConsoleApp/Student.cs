using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    interface IEqual<T>
    {
        bool isEqual(T obj);
    }

    abstract class Person
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }

        public Person(string fName, string lName)
        {
            this.FirstName = fName;
            this.LastName = lName;
        }

        public abstract string toString();

    }

    class Student : Person, IEqual<Student>
    {
        private string regno;

        public Student(string FirstName, string LastName, string RegNo):
            base(FirstName, LastName)
        {
            this.regno = RegNo;
        }

        public override string toString()
        {
            return this.FirstName + " " + this.LastName + " " + this.regno;
        }

        public bool isEqual(Student student)
        {
            if (this.regno == student.regno)
                return true;
            return false;
        }
    }

    class Employee : Person, IEqual<Employee>
    {
        public string Designation { get; set; }
        public string Department { get; set; }

        public Employee(string FirstName, string LastName, string Designation, string Department) :
            base(FirstName, LastName)
        {
            this.Designation = Designation;
            this.Department = Department;
        }

        public override string toString()
        {
            return this.FirstName + " " + this.LastName + " " + this.Designation + " " + this.Department;
        }

        public bool isEqual(Employee employee)
        {
            if (this.Designation == employee.Designation)
                return true;
            return false;
        }

    }
}
