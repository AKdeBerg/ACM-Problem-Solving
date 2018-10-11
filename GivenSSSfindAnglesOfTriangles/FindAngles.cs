using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GivenSSSfindAnglesOfTriangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the three sides of the triangles: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            double side2 = Convert.ToDouble(Console.ReadLine());
            double side3 = Convert.ToDouble(Console.ReadLine());

            //write a method to calculate triangle
            TriangleCalculation(side1, side2, side3);

            Console.ReadLine();

        }

        static void TriangleCalculation(double side1, double side2, double side3)
        {
            double angle1, angle2, angle3;
            //find the largest side
            if (side1 > side2 && side1 > side3)
            {
                //side1 is the largest
                    //write method to calculate largest angle for side1
                    angle1 =  LargestAngleCalculation(side1, side2, side3);
                    //write a method to calculate other angles
                    angle2 = RemainingAngleCalculation(angle1, side1, side2);
                angle3 = 180 - (angle1 + angle2);
            }

            else if (side2 > side1 && side2 > side3)
            {
                //side2 is the largest
                    //write method to calculate largest angle for side2
                    angle2 = LargestAngleCalculation(side2, side1, side3);
                //write a method to calculate other angles
                angle1 = RemainingAngleCalculation(angle2, side2, side1);
                angle3 = 180 - (angle1 + angle2);

            }

            else 
            {
                //side3 is the largest
                    //write method to calculate largest angle for side3
                    angle3 = LargestAngleCalculation(side3, side1, side2);
                //write a method to calculate other angles
                angle1 = RemainingAngleCalculation(angle3, side3, side2);
                angle2 = 180 - (angle1 + angle3);

            }

            Console.WriteLine("Angle opposite to side3 = {0}", angle3);
            Console.WriteLine("Angle opposite to side2 = {0}", angle2);
            Console.WriteLine("Angle opposite to side1 = {0}", angle1);
        }

        static double LargestAngleCalculation(double largestSide, double smallestSide1, double smallestSide2)
        {
            //using laws of cosine
            double largestAngle = Math.Pow(smallestSide1, 2) + Math.Pow(smallestSide2, 2) - Math.Pow(largestSide, 2);
            largestAngle = Math.Abs(largestAngle / (2 * smallestSide1 * smallestSide2));
            largestAngle = Math.Acos(largestAngle) * 180.0 / Math.PI;
            return largestAngle;
        }

        static double RemainingAngleCalculation(double largestAngle, double largestSide, double smallerSide)
        {
            //we use law of sine here
            double smallerAngle = smallerSide * Math.Sin(largestAngle * Math.PI / 180);
            smallerAngle = smallerAngle / largestSide;
            smallerAngle = Math.Asin(smallerAngle) * 180.0 / Math.PI;

            return smallerAngle;
        }
    }
}
