using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_Management_System.Classes
{
    public class Supermarket
    {
        //paste your local absolute path here
        string filePath = "C:\\Users\\ILHAN\\source\\repos\\Supermarket-Management-System\\Supermarket-Management-System\\Data\\Products.txt";

        public void addProduct(Product product)
        {
            using StreamWriter textWriter = new StreamWriter(filePath, true);
            textWriter.WriteLine(product.ToString());
        }

        public void listProducts()
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
