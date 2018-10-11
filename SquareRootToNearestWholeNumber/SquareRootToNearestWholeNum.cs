using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRootToNearestWholeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int aNumber = Convert.ToInt32(Console.ReadLine());

            double sqrRooted = Math.Sqrt(aNumber);

            double nearestWholeNumber = Math.Round(sqrRooted);

            Console.WriteLine("The nearest whole number is {0}", nearestWholeNumber);

            Console.ReadKey();
        }
    }
}
