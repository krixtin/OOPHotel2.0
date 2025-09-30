using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHotel2._0.Persons
{
    internal class Manager : Persons
    {
        string Department { get; set; }


        public Manager(string name, int age, string employeeId, DateOnly startDate, Decimal salary) 
        {
            Name = name;
            Age = age;
            EmployeeId = employeeId;
            StartDate = startDate;
            Salary = salary;
        }

        public void HoldMeeting() 
        {
            Console.WriteLine("Chefen håller ett personalmöte på hotellet");
        }


        public override void Introduce() 
        {
            Console.WriteLine($"Hej jag heter {Name} och är {Age} år gammal. Jag arbetar som Manager.");
        }

    }
}
