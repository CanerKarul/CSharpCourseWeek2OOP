using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferanceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //    // int, decimali float, enum, boolean -> value types (değişken)
        //    /*
        //        STACK
        //          10->20
        //          20->1000
        //     */
        //    int sayi1 = 10; 
        //    int sayi2 = 20;

        //    sayi1 = sayi2;
        //    sayi2 = 100;

        //    Console.WriteLine("Sayi 1: " + sayi1);
        //    Console.WriteLine("Sayi 2: " + sayi2);

        //    // arrays, class, interface.. -> referance types
        //    /*
        //            STACK       HEAP                ->          Adress
        //102<-101    sayilar1    {1,2,3}             ->          101    
        //     102    sayilar2    {10->1000,20,30}    ->          102
            
        //    sayilar1 in adresinin 0. elemanı olacaktır. 
        //    sayilar 1 in adresi ilk başta 101 iken 102 olmuştur.
        //    101 adresi tutulmadığı için garbage collector (çöp toplayıcısı) tarafından silinecektir
        //     */
        //    int[] sayilar1 = new int[] { 1, 2, 3 };
        //    int[] sayilar2 = new int[] { 10, 20, 30 };

        //    sayilar1 = sayilar2;
        //    sayilar2[0] = 1000;

        //    Console.WriteLine("Sayilar 1[0]: " + sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Caner";

            person2 = person1;
            person1.FirstName = "Omar";

            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Hekim";

            Employee employee = new Employee();
            Person person3 = customer;
            Console.WriteLine(person3.FirstName);

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);


            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    // Base class : Person
    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
