using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Scholorship
    {
        int TotalMarks;
        float Fees;
        float ScholorshipAmount;

        static void Main(string[] args)
        {
            Scholorship s = new Scholorship();
            Console.WriteLine("Enter Total Marks");
            s.TotalMarks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Fees amount");
            s.Fees = Convert.ToSingle(Console.ReadLine());
            s.ScholorshipAmount = s.Merit(s.TotalMarks, s.Fees);
            Console.WriteLine("Scholorship Amount is " + s.ScholorshipAmount);
            Console.Read();

        }
        public float Merit(int TotalMarks, float Fees)
        {
            if (TotalMarks >= 70 && TotalMarks <= 80)
            {
                return (20.0f / 100) * Fees;
            }
            else if (TotalMarks > 80 && TotalMarks <= 90)
            {
                return (30.0f / 100) * Fees;
            }
            else if (TotalMarks > 90)
            {
                return (50.0f / 100) * Fees;
            }
            return 0;
        }

    }
}
