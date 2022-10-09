using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Concession
    {
        int TotalFare = 100;
        float CalculatedAmount;
        public void  CalculateConcession(int age)
        {

            if (age <= 5)
            {
                Console.WriteLine("Little Champs - Free Tickets");
            }
            else if (age >= 60)
            {
                CalculatedAmount = TotalFare - (0.3f * TotalFare);
                Console.WriteLine("Senior Citizen: " + CalculatedAmount);
            }
            else
            {
                Console.WriteLine("Toatal Fare: " + TotalFare);
            }
        }
    }
}
