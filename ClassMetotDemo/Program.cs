using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer(1,"Akın","KILIÇ");
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);

            Customer customer2 = new Customer(2,"Muharrem","CANDAN");
            customerManager.Add(customer2);

            Customer customer3 = new Customer(3,"Selçuk","ÖZDEMİR");
            customerManager.Add(customer3);

            customerManager.Delete(customer3);

            customerManager.Listing();
        }
    }
}
