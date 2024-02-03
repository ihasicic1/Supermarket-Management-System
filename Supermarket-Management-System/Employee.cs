using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_Management_System
{
    public abstract class Employee
    {
        public string Name { get; set; }

        public double BaseSalary { get; set; } = 1000;

        public abstract double CalculateSalary();

    }
}
