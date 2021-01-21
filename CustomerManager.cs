using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine(customer.Id + " " + customer.FirstName + " " + customer.LastName + " " + customer.AccountNumber + "Bilgilerine sahip müşteri eklendi!");
        }
        public void DeleteCumstomer(Customer customer)
        {
            Console.WriteLine(customer.Id + " " + customer.FirstName + " " + customer.LastName + " " + customer.AccountNumber + "Bilgilerine sahip müşteri silindi!");
        }
        public void ListCustomer(Customer customer)
        {
            Console.WriteLine(customer.Id + " " + customer.FirstName + " " + customer.LastName + " " + customer.AccountNumber);
        }
    }

}
