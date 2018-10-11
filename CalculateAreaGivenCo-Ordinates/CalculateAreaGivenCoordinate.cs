using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAreaGivenCo_Ordinates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the three x co-ordinates: ");
            double ax = Convert.ToDouble(Console.ReadLine());
            double bx = Convert.ToDouble(Console.ReadLine());
            double cx = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter the three y co-ordinates: ");
            double ay = Convert.ToDouble(Console.ReadLine());
            double by = Convert.ToDouble(Console.ReadLine());
            double cy = Convert.ToDouble(Console.ReadLine());


            //write a method to calculate the area
            double area = CalcualteAreaFromCoordinates(ax, bx, cx, ay, by, cy);

            Console.WriteLine("The area of the triangle is: {0}", area);

            Console.ReadKey();
        }

        static double CalcualteAreaFromCoordinates(double ax, double bx, double cx, double ay, double by, double cy)
        {
            double area = ax * (by - cy) + bx * (cy - ay) + cx * (ay - by);
            area = Math.Abs(area / 2);

            return area;
        }
    }
}
