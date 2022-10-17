
using System;

namespace Program
{
    class Cricket
    {
        static void no_of_matches(int Total) 
        { 
            float Average; int Sum = 0, Value; for (int i = 0; i < Total; i++) 
            { 
                Console.WriteLine("Enter a total runs in  matches : "); 
                Value = Convert.ToInt32(Console.ReadLine()); 
                Sum += Value; 
            }
            Average = (float)Sum / Total; 
            Console.WriteLine("Sum: " + Sum + ", Average: " + Average); 
        }
        static void Main(string[] args)
        {
            int Total; Console.WriteLine("Enter the total count of numbers: ");
            Total = Convert.ToInt32(Console.ReadLine());
            no_of_matches(Total);
            Console.ReadLine();
        }
    }
}



