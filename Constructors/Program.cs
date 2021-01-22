using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir class ilk kez oluştuğu zaman bir kere çalışır ve bir daha çalışmaz.
            Customer customer1 = new Customer() { 
                Id = 1,
                FirstName = "Sena",
                LastName = "Erdoğan",   
                City = "Ankara"
            };

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Seval";
            customer2.LastName = "Yıldırım";
            customer2.City = "İstanbul";

            Customer customer3 = new Customer(3, "Musa", "Er", "Sivas");

            Console.WriteLine(customer1.FirstName);
            Console.WriteLine(customer2.FirstName);
            Console.WriteLine(customer3.FirstName);

            Console.ReadLine();
        }
    }

    class Customer
    {
        //Default constructor -- Parametresi olmayan constructor
        public Customer()
        {
            Console.WriteLine("Constructor çalıştı...");
        }

        public Customer(int id, string firstName, string lastName, string city)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.City = city;

        }


        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
