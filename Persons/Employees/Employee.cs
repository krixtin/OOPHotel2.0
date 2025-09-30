using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHotel2._0.Persons.Employees
{
    internal class Employee : Person
    {
        public string JobTitle { get; set; }
        public string Department {  get; set; }

        public Employee(string name, int age, string employeeId, DateOnly startDate, decimal salary, string jobTitle, string department) 
        {
            Name = name;
            Age = age;
            StartDate = startDate;
            Salary = salary;
            JobTitle = jobTitle;
            Department = department;
        }
        
        public override void Introduce() 
        {
            Console.WriteLine($"Hej, jag heter {Name} och är {Age} år gammal. Jag jobbar på OOP Hotel.");
        }

        public virtual void Work()
        {
                Console.WriteLine($"{Name} arbetar som {JobTitle} på {Department}.");

        }
        
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Namn: {Name}\nÅlder: {Age}\nAnställnings-ID: {EmployeeId}\nStartdatum: {StartDate}\nLön: {Salary}\nAvdelning: {Department}");
        }

}
}
