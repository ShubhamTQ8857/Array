using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Employee
    {
        public int EId { get; set; }
        public string EName { get; set; }
        public double ESallary { get; set; }
    }
    public class JaggedArray3
    {
           static void Main(string[] args)
        {
            Employee[] List = new Employee[3]
                {
                    new Employee{EId=1, EName="Shubham", ESallary=25000},
                    new Employee{EId=2, EName="satyam", ESallary=20000},
                    new Employee{EId=3, EName="smita", ESallary=22000},
                };
            foreach(Employee e in List)
            {
                Console.WriteLine($"{e.EId} {e.EName} {e.ESallary}");
            }

        }

    }
}
