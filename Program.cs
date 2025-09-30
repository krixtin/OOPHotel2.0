using System.Security.Cryptography;
using OOPHotel2._0.Persons;
using OOPHotel2._0.Persons.Consultants;
using OOPHotel2._0.Persons.Employees;

namespace OOPHotel2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Test Employee
            Employee employee1 = new Employee("Adam Hillebrandt", 35, "E002", new DateOnly(2024,08,16), 21000,"Portier","Lobby" );
                    
            //Register över hotellpersonal
            List<Person> hotelStaff = new List<Person>();

            hotelStaff.Add(consultant1);
            hotelStaff.Add(employee1);
            hotelStaff.Add(new Manager("Matilda Beckström",55, "M002",new DateOnly(2015,09,12), 55000, "Ledning"));
            hotelStaff.Add(new Houskeeping("Sandra Forslund",32,"E005",new DateOnly(2022,04,24),22000,"Rumsstädare","Hotelstädare"));
            hotelStaff.Add(new Employee("Fatima Asgari", 27, "E006", new DateOnly(2023, 07, 05), 25000, "Receptionist", "Front desk"));

            //SKriv ut information om hotellpersonal

            Console.WriteLine("Hotellets personal:");
            foreach (var staffMember in hotelStaff)
            {
                staffMember.PrintInfo();
                staffMember.Introduce();

                if (staffMember is Manager manager)
                {
                    manager.HoldMeeting(); 
                }
                else if (staffMember is Employee employee)
                {
                    employee.Work();
                }
                else if (staffMember is Consultant consultant)
                {
                    consultant.GiveAdvice();           
                }
                //else if (staffMember is Houskeeping housekeeper)
                //{
                //    housekeeper.Work();
                //}
                Console.WriteLine();
            }
                         
            
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
