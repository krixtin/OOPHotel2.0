using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHotel2._0.Persons.Consultants
{
    internal class Consultant : Person
    {
        public void GiveAdvice()
        {
            Console.WriteLine($"{Name} ger råd till hotellet om hur de kan förbättra sina rutiner.");
            Console.WriteLine($"{Name}s expertområde är att {Expertise}");
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Namn: {Name}\nÅlder: {Age}\nAnställnings-ID: {EmployeeId}\nStartdatum: {StartDate}\nSalary: {Salary}");
        }

        public override void Work()
        {
            Console.WriteLine($"Konsulten {Name} tillhandahåller hotellet sina tjänster inom {Expertise}.");
        }

        public double HourlyRate { get; set; }

        public string ConsultingFirm { get; set; }

        public string Expertise { get; set; }

        
        public Consultant()
        {

        }
    }
}
