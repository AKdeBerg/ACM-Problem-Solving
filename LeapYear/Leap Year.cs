using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            //enter a year
            Console.WriteLine("Enter a year: ");
            long year = Convert.ToInt64(Console.ReadLine());


            //a year would be leap year if it is divisble by 400 or if it not divisble with 100 but 4
            if ( (year % 400 == 0) || (year % 100 != 0 && year % 4 == 0))
            {
                Console.WriteLine("{0} is a leap year!", year);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year :(", year);
            }

            Console.ReadKey();
        }
    }
}
