using System;

namespace CalculateCircumferenceGivenRadius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius of a circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            //write a method to calculate the circumference
            double circumference = CalculateCircumference(radius);
            Console.WriteLine("The circumference of the circle is: {0}", circumference);

            Console.ReadKey();
        }

        static double CalculateCircumference(double radius)
        {
            double circumference = 2 * Math.PI * radius;

            return circumference;
        }
    }
}
