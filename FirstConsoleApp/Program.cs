using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student Class Demo
            Student sObj = new Student();
            sObj.FirstName = "Ahmed";
            sObj.LastName = "Ali";
            Console.WriteLine(sObj.FirstName + ", " + sObj.LastName);

            // Employee Class Demo
            Employee eObj = new Employee("Zaheer")
            {
                Department = "CS",
                Designation = "Lecturer"
            };
            Console.WriteLine("Employee Name: " + eObj.Name);


            //Program.StructDemo();
            Console.ReadKey();
        }

        static void StructDemo()
        {
            RegNo regNo = new RegNo(Session.SP, 2016, DegreeProgram.BSE, "012");
            if (regNo.getSession() == Session.FA)
                Console.WriteLine("Student is from Fall Session");
            else if (regNo.getSession() == Session.SP)
                Console.WriteLine("Student is from Spring Session");

            Console.WriteLine(regNo);
        }

        static string ChooseSeason(Season season)
        {
            return season.ToString();
        }

    }
}
