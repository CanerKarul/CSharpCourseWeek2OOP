using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        // interface new'lenemez
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();
            
            IPersonManager employeeManager = new EmployeeManager();
            

            Console.ReadLine();
        }
    }

    // inherits - class ------------- implements - interface
    interface IPersonManager
    {
        // UnImplemented operation
        void Add();
        void Update();
    }

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            // Müşteri ekleme kodları
            Console.WriteLine("Müşteri eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            // Personel ekleme kodları
            Console.WriteLine("Personel eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi");
        }
    }

    class ProjectManager
    {
        public void AddCustomer(CustomerManager customerManager)
        {
            customerManager.Add();
        }

        public void AddEmployee(EmployeeManager employeeManager)
        {
            employeeManager.Add();
        }
    }

}
