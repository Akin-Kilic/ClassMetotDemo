using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class Customer
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Customer()
        {

        }
        public Customer(int id, string FirstName, string LastName)
        {
            this.id = id;
            this.FirstName = FirstName;
            this.LastName = LastName;

        }
        
    }
}
