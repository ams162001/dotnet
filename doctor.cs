using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Doctor
    {
        private int RegNo { get; set; }

        private string Name { get; set; }

        private int FeesCharged { get; set; }

        static void Main(string[] args)
        {
            Doctor d = new Doctor();
            d.setName();
            d.getName();
            Console.Read();

        }
        public void setName()
        {
            Name = "Yahwanth";
            RegNo = 8;
            FeesCharged = 100;
        }
        public void getName()
        {
            Console.WriteLine("********Doctor fee******");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Register No :" + RegNo);
            Console.WriteLine("FeesCharged: " + FeesCharged);
        }
    }
}
