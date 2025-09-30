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
           
            hotelStaff.Add(employee1);
            hotelStaff.Add(new Manager("Matilda Beckström",55, "M002",new DateOnly(2015,09,12), 55000, "Ledning"));
            hotelStaff.Add(new Houskeeping("Sandra Forslund",32,"E005",new DateOnly(2022,04,24),22000,"Rumsstädare","Hotelstädare"));
            hotelStaff.Add(new Employee("Fatima Asgari", 27, "E006", new DateOnly(2023, 07, 05), 25000, "Receptionist", "Front desk"));
            hotelStaff.Add(new Consultant("Eva Expert", 48, "C001", new DateOnly(2023, 07, 22), 45000, 1500, "Hotel Consultants Corp.", "Ledning"));

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
            }
                         
            
        }


    }
}
