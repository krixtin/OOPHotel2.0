using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHotel2._0.Persons
{
    internal abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string EmployeeId { get; set; }
        public DateOnly StartDate { get; set; }
        public decimal Salary { get; set; } 


        public void PrintInfo()
        {
            Console.WriteLine($"Namn: {Name}\nÅlder: {Age}");
        }

        public virtual void Introduce() {}    

    }
}
