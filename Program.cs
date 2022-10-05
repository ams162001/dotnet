using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    //Create a class called Customer with Customerid, Name, Age, Phone,City. Write a constructor with no arguments and
    //another constructor with all information.  Write a method called DisplayCustomer(),
    //which is called directly without any object. Also  include destructor

    class Customer
    {
        int CustomerId;
        string Name;
        int age;
        string Phone;
        string City;

        public static void Main(string[] args)
        {
            Console.WriteLine("**********Customer Details**********");
            Customer c1 = new Customer(10, "Aish", 22, "9876543210", "mysore");
            DisplayCustomer(c1);
            Customer c2 = new Customer();
            GC.Collect();



        }

        public Customer()
        {

        }
        public Customer(int CustomerId, string Name, int age, string Phone, string City)
        {
            this.CustomerId = CustomerId;
            this.Name = Name;
            this.age = age;
            this.Phone = Phone;
            this.City = City;
        }
        public static void DisplayCustomer(Customer customer)
        {
            Console.WriteLine("Customer Id: " + customer.CustomerId);
            Console.WriteLine("Customer Name: " + customer.Name);
            Console.WriteLine("Customer age: " + customer.age);
            Console.WriteLine("Phone Number: " + customer.Phone);
            Console.WriteLine("City: " + customer.City);
        }

        ~Customer()
        {
            Console.WriteLine("Thank You...!!! Destructor Called");
            Console.ReadLine();
        }
    }
}
