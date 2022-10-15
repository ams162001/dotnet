using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ASSIGNMENT_6_4_
{
    class GENERICDEMO
    {
        static void Main()
        {
            List<string> items = new List<string>();
            items.Add("SCALE");
            items.Add("NOTEBOOK");
            List<string> newitems = new List<string>();
            newitems.Add("ERASER");
            newitems.Add("STCIKYNOTES");
            items.AddRange(newitems);
            Console.WriteLine("Accessing Generic List using For Each Loop");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nAccessing Individual List Element by Index Position");
            Console.WriteLine($"First Element: {items[0]}");
            Console.WriteLine($"Second Element: {items[1]}");
            Console.WriteLine($"Third Element: {items[2]}");
            Console.WriteLine($"Fourth Element: {items[3]}");
            Console.ReadLine();
        }
    }
}
