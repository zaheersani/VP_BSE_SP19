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
            // Inheritance Demo
            Student sObj = new Student("Ahmed", "Raza", "SP12-BCS-098");
            Employee eObj = new Employee("Zaheer", "Sani", "Lecturer", "CS");

            Person pObj = new Student("Person", "Student", "SP12-BCS-098");
            Person pObj2 = new Employee("Person", "Employee", "Lecturer", "CS");

            if (sObj.isEqual(sObj))
                Console.WriteLine("Both are equal");

            Console.WriteLine(pObj.toString());
            Console.WriteLine(pObj2.toString());
            Console.WriteLine();
            Console.WriteLine(sObj.toString());
            Console.WriteLine(eObj.toString());

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
