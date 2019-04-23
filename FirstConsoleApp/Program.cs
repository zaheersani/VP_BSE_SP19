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
            // LINQ Demo
            int[] nums = new int[] { 2, 3, 2, 62, 3, 445, 45, 45, 4, 34, 67, 6, 46, 46, 67, 99 };
            var result = from n in nums
                         where n % 2 == 0
                         select n;
            Console.WriteLine("Max int: " + result.Max());
            Console.WriteLine("Min int: " + result.Min());
            Console.WriteLine("Average of ints: " + result.Average());
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }

            string[] names = new string[] { "Ali", "Sarfraz", "Lodhi", "Ahmed" };
            var r = from n in names
                    where n.Length > 3 && n.ToLower().StartsWith("s")
                    select n;
            foreach (var item in r)
            {
                Console.WriteLine(item);
            }

            List<Student> sObjs = new List<Student>();
            sObjs.Add(new Student("Ali", "Hassan", "SP16-BSE-034"));
            sObjs.Add(new Student("Sarfraz", "Ahmed", "SP16-BSE-054"));
            sObjs.Add(new Student("Zafar", "Salman", "SP16-BSE-004"));

            IEnumerable<Student> sResult = from student in sObjs
                                           where student.FirstName.StartsWith("Ali")
                                           select student;

            
            foreach (Student item in sResult)
            {
                Console.WriteLine(item);
            }

            // TODO: Write LINQ statement to filter the results of an int array
            // based on the criteria:
            // Return all numbers which are divisible by 5, 7 or 13
            // and are greater than 100 and less than 1000
            // Print all Numbers in sorted order
            // Print average of Numbers
            // Pring Maximum and Minimum value 

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
