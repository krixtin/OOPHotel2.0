using System.Security.Cryptography;
using OOPHotel2._0.Persons;
using OOPHotel2._0.Persons.Consultants;
using OOPHotel2._0.Persons.Employees;
using OOPHotel2._0.Persons;

namespace OOPHotel2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            DateOnly managerStartDate = new DateOnly(2025, 03, 19);
            Manager manager = new Manager("Aldor", 67, "CCAA", managerStartDate, 40000, "Chefer");

            manager.PrintInfo();
            manager.Introduce();
            manager.HoldMeeting();

            Console.WriteLine();

            DateOnly consultantStartDate = new DateOnly(2025, 04, 30);
            Consultant consultant1 = new Consultant("Eva Expert", 48, "C001", consultantStartDate, 45000, 1500, "Hotel Consultants Corp.", "Ledning");
            
            Console.WriteLine("Konsult:");
            consultant1.PrintInfo();
            consultant1.Introduce();
            consultant1.GiveAdvice();

            Console.WriteLine();

            DateOnly houskeeper1StartDate = new DateOnly(2025, 03, 20);

            Houskeeping houskeeper1 = new Houskeeping("Pelle", 43, "E001", houskeeper1StartDate, 30000, "städare", "lokalvård");

            houskeeper1.PrintInfo();
            houskeeper1.Introduce();
            houskeeper1.Work();

        }
    }
}
