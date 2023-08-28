
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class EmployeeArrayClass
    {
            int id;
            string name;
            int salary;

            public EmployeeArrayClass(int id, string name, int salary)
            {
                this.id = id;
                this.name = name;
                this.salary = salary;
            }

            public string Display()
            {
                return id + " " + name + " " + salary;
            }

    }

    }

