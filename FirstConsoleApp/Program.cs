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
            //Program.ArgsCheck(args);
            Console.WriteLine("Max value of int = " + uint.MaxValue);
            Console.Write("Enter int value = ");
            string val = Console.ReadLine();
            ulong? i = (ulong)uint.Parse(val) + 1000;
            Console.WriteLine("Value of int i " + i);
            //double j = 3.5;
            //Console.WriteLine("{0}/{1}={2}", i, j, i/j);
            Console.ReadKey();
        }
        static void ArgsCheck(string[] args)
        {
            if (args.Length > 0)
            {
                if (args[0] == "A1@r2")
                {
                    Console.WriteLine("My BitCoins Wallet Address i RjlkOLFRThfEYFCSWOOMBHUJBFTIHGYFcyIUG&98&VIUTFIYTi");
                    Console.WriteLine("It contains 500 BitCoins");
                }
                else
                    Console.WriteLine("Wrong Secret Key...Your System will lock down in 3 seconds");
            }
            else
                Console.WriteLine("At least one argument is required");

            Console.ReadKey();
        }
    }
}
