using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id=1, City="Malatya", FirsName="Caner", LastName= "Karul"};
            Customer customer2 = new Customer(2,"Diyarbekir", "Hekim", "Kaya");

            Console.WriteLine(customer2.FirsName);
            Console.ReadLine();
        }
    }

    class Customer
    {
        public Customer()
        {
            
        }

        // Default constructor
        public Customer(int id, string city, string firstName, string lastName)
        {
            Id = id;
            City = city;
            FirsName = firstName;
            LastName = lastName;
        }

        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
