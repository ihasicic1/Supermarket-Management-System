using Supermarket_Management_System.Classes;
using System.Globalization;

namespace Supermarket_Management_System
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Supermarket supermarket = new Supermarket();
            Customer customer = new Customer();
            var customers = getCustomers();

            while (true)
            {
                Console.WriteLine("Welcome to supermarket.");
                Console.WriteLine("Input your username: ");
                string username = Console.ReadLine();
                Console.WriteLine("Input your password: ");
                string password = Console.ReadLine();
                Customer validatedCustomer = validateCustomer(username, password, customers);
                if(validatedCustomer != null)
                {
                    Console.WriteLine($"Welcome {validatedCustomer.username}.");

                    while(validatedCustomer.username == "Ilhan5830i")
                    {
                        Console.WriteLine("Choose an option:");
                        Console.WriteLine("1. List products");
                        Console.WriteLine("2. Add product");
                        Console.WriteLine("3. Show customers");
                        Console.WriteLine("4. Exit");

                        string option = Console.ReadLine();

                        switch (option)
                        {
                            case "1":
                                supermarket.listProducts();
                                break;
                            case "2":
                                Console.WriteLine("Input the type of a product: ");
                                string type = Console.ReadLine();
                                Console.WriteLine("Input the price of a product: ");
                                string price = Console.ReadLine();
                                Product product = new Product(type, Convert.ToDouble(price));
                                supermarket.addProduct(product);
                                Console.WriteLine($"You have successfully added {product.type} for a price of {product.price}.");
                                break;
                            case "3":
                                supermarket.listCustomers();
                                break;
                            case "4":
                                Console.WriteLine("Thank you for your time!");
                                return;
                            default:
                                Console.WriteLine("Invalid option. Try again.");
                                break;
                        }
                    }
                    while(validatedCustomer.username != "Ilhan5830i")
                    {
                        Console.WriteLine("Choose an option:");
                        Console.WriteLine("1. List products");
                        Console.WriteLine("2. Show my balance");
                        Console.WriteLine("3. Buy product");
                        Console.WriteLine("4. Exit");

                        string option = Console.ReadLine();
                        switch (option)
                        {
                            case "1":
                                supermarket.listProducts();
                                break;
                            case "2":
                                Console.WriteLine($"Your balance is {validatedCustomer.balance}");
                                break;
                            case "3":
                                Console.WriteLine("Input the type of a product you want to buy: ");
                                string type = Console.ReadLine();
                                Console.WriteLine("Input the price of a product you want to buy: ");
                                string price = Console.ReadLine();
                                Product product = new Product(type, Convert.ToDouble(price, CultureInfo.InvariantCulture));
                                validatedCustomer.buyProduct(product);
                                break;
                            case "4":
                                Console.WriteLine("Thank you for your time!");
                                return;
                            default:
                                Console.WriteLine("Invalid option. Try again.");
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid username or password. Try again.");
                }
            }
        }

        private static List<Customer> getCustomers()
        {
            string filePath = "C:\\Users\\ILHAN\\source\\repos\\Supermarket-Management-System\\Supermarket-Management-System\\Data\\Customers.txt";
            List<Customer> customers = new List<Customer>();
            
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] values = line.Split(',');
                    string username = values[0];
                    string password = values[1];
                    

                    customers.Add(new Customer(username, password));
                }
            return customers;
        }

        private static Customer validateCustomer(string username, string password, List<Customer> customers)
        {
            return customers.FirstOrDefault(c => c.username == username && c.password == password);
        }
    }
}