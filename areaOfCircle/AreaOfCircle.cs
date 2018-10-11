using System;

namespace areaOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * radius * radius;

            Console.WriteLine("The area of the circle is: {0}", area);
            Console.ReadKey();

        }
    }
}
