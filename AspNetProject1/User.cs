using System;
using System.Collections.Generic;
using System.Linq;
namespace AspNetProject1
{
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Email { get; set; }


    }

    class Account : User
    {
        public static List<Product> products = new List<Product>()
        {
            new Product(){Id=198,Name="oil",Price=100}
        };

        private static List<Customer> customers = new List<Customer>()
        {
            new Customer(){Id=102,Name="Abdullah",Email="abdullah@gmail.com"}
        };

        public static void AddProduct(string name, double price)

        {
            Random rand = new Random();
            string idstr = $"{products.Count}{rand.Next(10, 100)}";
            int id = Convert.ToInt32(idstr);
            products.Add(new Product() { Id = id, Name = name, Price = price });
        }
        public static void UpdateProduct(int id,string name, double price)
        {
            products.Where(p => p.Id==id).ToList()
           .ForEach(x => {
               x.Name = name;
               x.Price = price;
                           });
        }

        public static void DeleteProduct(int id)
        {
            products.RemoveAll(p => p.Id == id);
        }


        
        public static void AddCustomer(string name, string email)
        {
            Random rand = new Random();
            string idstr = $"{customers.Count}{rand.Next(10, 100)}";
            int id = Convert.ToInt32(idstr);
            customers.Add(new Customer() { Id = id, Name = name, Email = email });
        }
        public static void UpdateCustomer(int id, string name, string email)
        {
            customers.Where(c => c.Id == id).ToList()
           .ForEach(x => {
               x.Name = name;
               x.Email = email;
           });
            
        }
        public static void DeleteCustomer(int id)
        {
            customers.RemoveAll(c => c.Id == id);
        }

        public List<Customer> GetCustomers()
        {
            return customers;
        }
        public List<Product> GetProducts()
        {
            return products;
        }



    }
    class Admin : Account
    {
        private static List<Accountant> accountants = new List<Accountant>()
        {
            new Accountant(){Id=122,Name="Amjad",Email="amjad@gmail.com"}
        };


        public static void AddAccountant(string name, string email)
        {
            Random rand = new Random();
            string idstr = $"{accountants.Count}{rand.Next(10, 100)}";
            int id = Convert.ToInt32(idstr);
            accountants.Add(new Accountant() { Id = id, Name = name, Email = email });
        }

        public static void UpdateAccountant(int id, string name, string email)
        {
            accountants.Where(a => a.Id == id).ToList()
           .ForEach(x => {
               x.Name = name;
               x.Email = email;
           });

        }
        public static void DeleteAccountant(int id)
        {
            accountants.RemoveAll(a => a.Id == id);
        }
    }
    class Accountant : Account
    {

    }
    class Customer : User
    {
  
    }
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

    }
    class BillEntries
    {

    }
}