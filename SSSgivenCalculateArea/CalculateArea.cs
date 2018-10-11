using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSSgivenCalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //taking input
            Console.WriteLine("Enter 3 sides of a triangle: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            double side2 = Convert.ToDouble(Console.ReadLine());
            double side3 = Convert.ToDouble(Console.ReadLine());


            //write a method to calculate area
            double area = CalculateArea(side1, side2, side3);
            string ourArea = area.ToString("0.00"); //truncating the digits to 2 decimal places
            Console.WriteLine("The area of the triangle is: {0}", ourArea);
            Console.ReadKey();
        }

        static double CalculateArea(double side1, double side2, double side3)
        {
            double p = (side1 + side2 + side3) / 2;

            double area = Math.Sqrt(p*(p - side1) * (p - side2) * (p - side3));

            return area;
        }
        
    }
}
