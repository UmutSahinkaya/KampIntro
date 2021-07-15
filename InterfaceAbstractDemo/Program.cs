using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Entities.Customer 
            { dayOfBirth = new DateTime(1994, 4, 5), 
                firstName = "Umut",
                lastName = "Şahinkaya",
                identityNumber = "28294579422" 
            });

        }
    }
   
}
