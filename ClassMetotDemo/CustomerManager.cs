using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {

        List<Customer> customers = new List<Customer>();

        public void Add(Customer customer)
        {
            customers.Add(customer);
            Console.WriteLine("Müşteri eklendi: " + customer.FirstName);
        }
        public void Delete(Customer customer)
        {
            customers.Remove(customer);
            Console.WriteLine("Müşteri silindi: " + customer.FirstName);
        }
        public void Listing()
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
        }
    }
}
