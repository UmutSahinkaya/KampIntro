using System;
using System.Collections.Generic;

namespace Week3DayHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer m1 = new Customer();
            m1.firstName = "Furkan";
            m1.lastName = "Demir";
            m1.cAge = 25;
            m1.identityNumber = "52147896321";

            Customer m2 = new Customer();
            m2.firstName = "Hakan";
            m2.lastName = "ÖzDemir";
            m2.cAge = 30;
            m2.identityNumber = "47521589632";

            Customer m3 = new Customer();
            m3.firstName = "Mehmet";
            m3.lastName = "Dağcı";
            m3.cAge = 36;
            m3.identityNumber = "21354789632";

            Customer m4 = new Customer();
            m4.firstName = "Hakkı";
            m4.lastName = "Bulut";
            m4.cAge = 19;
            m4.identityNumber = "15478963257";

            Customer m5 = new Customer();
            m5.firstName = "Leyla";
            m5.lastName = "Koçak";
            m5.cAge = 21;
            m5.identityNumber = "24568741236";

            Customer m6 = new Customer();
            m6.firstName = "Özgür";
            m6.lastName = "Korkmaz";
            m6.cAge = 27;
            m6.identityNumber = "25631478596";

            List<Customer> customers =new List<Customer> { m1,m2,m3,m4,m5,m6};
            CustomerManager customermanager = new CustomerManager();
            customermanager.getAll(customers);
            customermanager.add(m1);

        }
    }
}
