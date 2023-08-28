using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class ArrayMethodClass1
    {
        static void Main(string[] args)
        {
            EmployeeArrayClass[] emp = new EmployeeArrayClass[3];
            emp[0] = new EmployeeArrayClass(101, "Shubham", 78000);
            emp[1] = new EmployeeArrayClass(101, "Shubham", 78000);
            emp[2] = new EmployeeArrayClass(101, "Shubham", 78000);

           /*foreach(EmployeeArrayClass e in emp)
            {
                Console.WriteLine(e);
            }*/

            for(int i=0; i<emp.Length; i++)
            {
                Console.WriteLine(emp[i]);
            }
           
        }
    }
}
