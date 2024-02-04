using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_Management_System.Classes
{
    public class Manager : Employee
    {
        public double managerSalary;
        public double managerSalaryBonus = 1000;
        public override double calculateSalary()
        {
            return baseSalary + managerSalaryBonus;
        }
    }
}
