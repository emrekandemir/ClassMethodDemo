using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Ahmet";
            customer1.LastName = "Kara";
            customer1.Phone = 12346789;
            customer1.Address = "İstanbul";
            customer1.Balance = 0;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Mehmet";
            customer2.LastName = "Yara";
            customer2.Phone = 987654321;
            customer2.Address = "İzmir";
            customer2.Balance = 0;

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Ayşe";
            customer3.LastName = "Cura";
            customer3.Phone = 147258369;
            customer3.Address = "Ankara";
            customer3.Balance = 0;

            Customer[] customer = new Customer[] {customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Delete(customer3);
            customerManager.List(customer);

        }
    }
}
