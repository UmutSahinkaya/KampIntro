using System;
using System.Collections.Generic;
using System.Text;

namespace Week3DayHomework
{
    class CustomerManager
    {
        public void add(Customer customer)
        {
          
            Console.WriteLine("Müşteri eklendi: ->" +customer.firstName);
            
        }
        public void delete(Customer customer)
        {
            Console.WriteLine("Müşteri silindi: ->"+customer.firstName);
        }
        public void getAll(List<Customer> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Müşteri eklendi: ->" + customer.firstName);
                Console.WriteLine("Müşteri adı:{0} \nMüşteri Yaşı:{1}\nMüşteri Tc Kimlik No:{2} \n\n", customer.firstName + " " + customer.lastName, customer.cAge, customer.identityNumber);
            }
        }
    }
}
