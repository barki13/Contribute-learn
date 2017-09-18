using System;

namespace RectangleApplication
{
    class Rectangle
    {
        // member variables
        double length;
        double width;

        public void AcceptDetails()
        {
            length = 4.5;
            width = 3.5;
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    } // end class Rectangle

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new RectangleApplication.Rectangle();
            r.AcceptDetails();
            r.Display();
            Console.ReadLine();
        }
    }
}
