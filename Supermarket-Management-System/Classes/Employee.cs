using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_Management_System.Classes
{
    public abstract class Employee
    {
        public string name { get; set; }

        public double baseSalary { get; set; } = 1000;

        public abstract double calculateSalary();

    }
}
