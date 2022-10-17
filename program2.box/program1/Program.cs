using System;

namespace RectangleApplication
{

    class Box
    {
        // member variables
        double length;
        double width;

        public void Acceptdetails()
        {
            length = 10.5;
            width = 20.5;
        }

        public double GetAddition()
        {
            return length + width;
        }

        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Addition: {0}", GetAddition());
        }
    }

    class ExecuteBox
    {

        static void Main(string[] args)
        {
            Box r = new Box();
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();
        }
    }
}

