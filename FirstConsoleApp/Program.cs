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
            //Phone Book Demo
            PhoneBook phoneBook = new PhoneBook();
            phoneBook.AddContact(new Contact()
            {
                Name = "Ali",
                Number = "0345768976"
            });
            phoneBook.AddContact(new Contact()
            {
                Name = "Raza",
                Number = "0333454"
            });
            Console.WriteLine(phoneBook.GetContact(0).Name);
            Console.WriteLine(phoneBook[0].Name);

            phoneBook[0] = new Contact()
            {
                Name = "Ali Hassan",
                Number = "+92343434343"
            };

            Console.WriteLine(phoneBook[0].Name);
            Console.WriteLine(phoneBook["Ali"].Number);

            Console.WriteLine(phoneBook["0333", ContactType.Number].Name);

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
