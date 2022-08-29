using System;
using OOP2;

namespace OPP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Individual customer1 = new Individual();
            customer1.CustomerNumber = "12345";
            customer1.IdentityNumber = "1122233";
            customer1.LastName = "Mirzooğlu";
            customer1.Id = 1;
            customer1.Name = "Zeynep";

            Coorporate customer2 = new Coorporate();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "1231534849879";

            //inheritance (kalıtım ile hem Individual hem Coorporate için referans numaralarını tutuyor)
            Customer customer3= new Individual();
            Customer customer4= new Coorporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);
        }
    }
}
