using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Day1DotNetExample
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to check both values are equal");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Program program = new Program();
            program.result(num1, num2);
            Console.WriteLine("");
            Console.WriteLine("***************Exercise 2*************");
            Console.WriteLine("enter a number to check positive or negative");
            Ex2 ex = new Ex2();
            ex.PositiveOrNegative();
            Console.WriteLine("");
            Console.WriteLine("*********Exercise 3************");
            Ex3 ex3 = new Ex3();
            ex3.calc();
            Console.ReadKey();
        }
        public void result(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("{0} and {1} are equal ", num1, num2);
            }
            else
            {
                Console.WriteLine("{0} and {1} are not equal ", num1, num2);
            }
        }



    }
    public class Ex2
    {
        public int val1 = 0;
        public int val2 = Convert.ToInt32(Console.ReadLine());
        public void PositiveOrNegative()
        {
            if (val1 > val2)
            {
                Console.WriteLine($"the given number {val2} is Negative");
            }
            else
            {
                Console.WriteLine($"the given number {val2} is Positive");
            }
        }
    }
    public class Ex3
    {

        public void calc()
        {
            Console.WriteLine("enter two numbers for perform Arithmetic operations");
            int val1 = Convert.ToInt32(Console.ReadLine());



            int val2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Arithmetic operation Which you want to calculate.");
            Console.WriteLine("1 for addition");
            Console.WriteLine("2 for subtraction");
            Console.WriteLine("3 for multiplication");
            Console.WriteLine("4 for division");
            int symbol = Convert.ToInt32(Console.ReadLine());
            if (symbol == 1)
            {
                Console.WriteLine("Answer is ", val1 + val2);
            }
            else if (symbol == 2)
            {
                Console.WriteLine("Answer is", val1 - val2);
            }
            else if (symbol == 3)
            {
                Console.WriteLine("Answer is", val1 * val2);
            }
            else if (symbol == 4)
            {
                Console.WriteLine("Answer is", val1 / val2);
            }
            else
            {
                Console.WriteLine("enter valid number");
            }
        }



    }
}
