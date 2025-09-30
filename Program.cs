using System.Security.Cryptography;
using OOPHotel2._0.Persons;
using OOPHotel2._0.Persons.Consultants;

namespace OOPHotel2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Consultant consultant1 = new Consultant
            {
                Name = "Eva Expert",
                Age = 48,
                EmployeeId = "C001",
                StartDate = new DateOnly(2025, 04, 30),
                Salary = 0,
                HourlyRate = 1500,
                ConsultingFirm = "Hotel Consultants corp."
            };

            Console.WriteLine("Konsult:");
            consultant1.PrintInfo();
            consultant1.Introduce();
            consultant1.GiveAdvice();
            Console.WriteLine($"Timlön: {consultant1.HourlyRate} kr");
            Console.WriteLine($"Konsultfirm: {consultant1.ConsultingFirm}");

            Manager manager = new Manager();

        }
    }
}
