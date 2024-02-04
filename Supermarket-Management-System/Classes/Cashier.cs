using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_Management_System.Classes
{
    public class Cashier : Employee
    {
        public double cashierSalary;
        public double cashierSalaryBonus = 500;
        public override double calculateSalary()
        {
            return baseSalary + cashierSalaryBonus;
        }
    }
}
