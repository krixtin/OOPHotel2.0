using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHotel2._0.Persons.Employees
{
    internal class Houskeeping : Employee
    {
        public Houskeeping(string name, int age, string employeeId, DateOnly startDate, decimal salary, string jobTitle, string department) : base(name, age, employeeId, startDate, salary, jobTitle, department) 
        {
            Name = name;
            Age = age;
            StartDate = startDate;
            Salary = salary;
            JobTitle = jobTitle;
            Department = department;

        }

        public override void Work()
        {
            Console.WriteLine($"{Name} städar hotellet.");

        }


    }
}
