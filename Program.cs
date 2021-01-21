using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            
                customer1.Id = 1;
                customer1.FirstName = "Ahsen";
                customer1.LastName = "Çelen";
                customer1.AccountNumber = 123456789;
            
                Customer customer2 = new Customer();
                customer2.Id = 2;
                customer2.FirstName = "Engin";
                customer2.LastName = "Demiroğ";
                customer2.AccountNumber = 987654321;
            
                Customer customer3 = new Customer();
                customer3.Id = 3;
                customer3.FirstName = "Alara";
                customer3.LastName = "Cesur";
                customer3.AccountNumber = 456123789;
            
        
            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            CustomerManager customerManager = new CustomerManager();
            foreach (Customer customer in customers)
            {
                customerManager.AddCustomer(customer);
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("Lütfen, silmek istediğiniz kişinin Id'sini giriniz.");
            int deleteId = Convert.ToInt32(Console.ReadLine());
            foreach (Customer customer in customers)
            {
                if (customer.Id == deleteId)
                {
                    customerManager.DeleteCumstomer(customer);
                    break;
                }

            }
            Console.WriteLine("----------------------");
            Console.WriteLine("Müşteriler Listelendi");
            foreach (Customer customer in customers)
            {
                customerManager.ListCustomer(customer);
            }
        }
    }
}
