using System;

namespace LessonRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "İstanbul";

            Customer customer1 = new Customer
            {
                Id = 2,
                City = "İstanbul",
                Name = "Ozgur"
            };

            Console.WriteLine(customer1.Name);
            Console.ReadLine();
        }
    }

}
