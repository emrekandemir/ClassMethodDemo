using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager  // Ortak kodlarımızı operasyonlarımızın bulunuduğu alandır.
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Id +":" + customer.FirstName + "|" + customer.LastName + "|" + customer.Address + "|" + customer.Phone + "|" + customer.Balance + "|" + "Addeed.");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Id + ":" + customer.FirstName + "|" + customer.LastName + "|" + customer.Address + "|" + customer.Phone + "|" + customer.Balance + "|" + "Deleted.");
        }
        public void List(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Id + ":" + customer.FirstName + "|" + customer.LastName + "|" + customer.Address + "|" + customer.Phone + "|" + customer.Balance);
            }
        }

    }
}
