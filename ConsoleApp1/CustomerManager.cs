using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.firstName + "---Müşteri Eklendi!");
        }
        public void Update(Customer customer)
        {
            Console.WriteLine(customer.firstName+"---Müşteri Güncellendi!");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.firstName + "---Müşteri Kaydı Silindi.");
        }
    }
}
