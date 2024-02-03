using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_Management_System
{
    public class Cashier : Employee
    {
        public double CashierSalary;
        public double CashierSalaryBonus = 500;
        public override double CalculateSalary()
        {
            return BaseSalary + CashierSalaryBonus;
        }
    }
}
