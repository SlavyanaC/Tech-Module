using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Andrey_and_Billiard
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> shop = new Dictionary<string, decimal>();
            int entitis = int.Parse(Console.ReadLine());
            for (int i = 0; i < entitis; i++)
            {
                //Shop items
                string[] entityArgs = Console.ReadLine().Split('-');
                var item = entityArgs[0];
                var price = decimal.Parse(entityArgs[1]);
                if (!shop.ContainsKey(item))
                {
                    shop.Add(item, price);
                }
                else
                {
                    shop[item] = price;
                }
            }

            List<Customer> customers = new List<Customer>();
            string order = Console.ReadLine();
            while (order != "end of clients")
            {
                //Cust info
                string[] orderArgs = order.Split(new char[] { '-', ',' });
                var customerName = orderArgs[0];
                var customerProduct = orderArgs[1];
                var quantity = int.Parse(orderArgs[2]);
                if (shop.ContainsKey(customerProduct))
                {
                    decimal customerBill = quantity * shop[customerProduct];
                    Customer customer = new Customer
                    {
                        Name = customerName,
                        ShopList = new Dictionary<string, int>(),
                        Bill = customerBill
                    };
                    customer.ShopList.Add(customerProduct, quantity);

                    if (customers.Any(x => x.Name == customerName))
                    {
                        //If customer makes new order
                        var currentcustomer = customers.First(x => x.Name == customerName);
                        if (currentcustomer.ShopList.ContainsKey(customerProduct))
                        {
                            //If customer orders the same product
                            currentcustomer.ShopList[customerProduct] += quantity;
                            currentcustomer.Bill += shop[customerProduct] * quantity;
                        }
                        else
                        {
                            //If customer orders new product
                            currentcustomer.ShopList[customerProduct] = quantity;
                            currentcustomer.Bill += shop[customerProduct] * quantity;
                        }
                    }
                    else
                    {
                        customers.Add(customer);
                    }
                }

                order = Console.ReadLine();
            }
            foreach (Customer customer in customers.OrderBy(s => s.Name))
            {
                Console.WriteLine(customer.Name);
                foreach (KeyValuePair<string, int> kvp in customer.ShopList)
                {
                    Console.WriteLine($"-- {kvp.Key} - {kvp.Value}");
                }
                Console.WriteLine($"Bill: {customer.Bill:F2}");
            }
            Console.WriteLine($"Total bill: {customers.Sum(s => s.Bill)}");
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> ShopList { get; set; }
        public decimal Bill { get; set; }
    }
}
