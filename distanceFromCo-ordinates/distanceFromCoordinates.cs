using System;
namespace distanceFromCo_ordinates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter x1 and y1 co-ordinates: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter x2 and y2 co-ordinates: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());

            double result = Distance(x1, y1, x2, y2);

            Console.WriteLine("The distance is: {0}", result);

            Console.ReadKey();

        }

        static double Distance(double x1, double y1, double x2, double y2)
        {
            double xDistanceSquared = (x2 - x1) * (x2 - x1);
            double yDistanceSquared = (y2 - y1) * (y2 - y1);

            double distance = Math.Sqrt(xDistanceSquared + yDistanceSquared);

            return distance;
        }



    }
}
