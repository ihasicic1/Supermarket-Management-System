using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_Management_System.Classes
{
    public class Customer
    {
        public double balance { get; set; } = 100;
        public string username;
        public string password;

        public Customer()
        {
        }

        public Customer(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public void buyProduct(Product product){
            if (product != null && exists(product) && balance >= product.price)
            {
                balance -= product.price;
                Console.WriteLine($"Congratulations! You bought {product.type} for {product.price}KM. Your balance is {balance}KM.");
            }
            else
            {
                Console.WriteLine("You do not have enough in your account balance to purchase this item.");
            }
        }

        private bool exists(Product product)
        {
            string filePath = "C:\\Users\\ILHAN\\source\\repos\\Supermarket-Management-System\\Supermarket-Management-System\\Data\\Products.txt";

            List<string> lines = File.ReadAllLines(filePath).ToList();
            foreach (string line in lines)
            {
                string[] values = line.Split(',');
                string type = values[0];
                double price = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
                if (type == product.type && price == product.price)
                {
                    return true;
                }
            }

            return false;
        }
    }
    
}
