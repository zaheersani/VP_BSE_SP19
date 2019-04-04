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
            // Operator Overloading Demo
            Box b1 = new Box()
            {
                Breadth = 5,
                Height = 5,
                Length = 5
            };
            Box b2 = new Box()
            {
                Breadth = 15,
                Height = 15,
                Length = 15
            };

            if (b1 > b2)
            {
                Console.WriteLine("Box1 is Greater than Box2");
            } else
            {
                Console.WriteLine("Box1 is Smaller than Box2");
            }


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
