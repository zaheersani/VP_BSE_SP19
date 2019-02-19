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
            Console.WriteLine("Hello World!");
            Console.WriteLine("From BSE-6A");
            if (args.Length > 0)
                Console.WriteLine(args[0]);
            Console.ReadKey();
        }
    }
}
