using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeNumbersSmallestToLargest
{
    class Program
    {
        static void Main(string[] args)
        {
            //take inputs
            Console.WriteLine("Enter three numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());


            //write a method to print numbers in ascending order
            PrintSmallestToLargestNumbers(num1, num2, num3);
            Console.ReadKey();
        }

        static void PrintSmallestToLargestNumbers(int num1, int num2, int num3)
        {
            if (num1 <= num2 && num1 <= num3)
            {
                Console.Write("{0} ", num1);

                if (num2 < num3)
                {
                    Console.Write("{0} {1}", num2, num3);
                }

                else
                {
                    Console.Write("{0} {1}", num3, num2);
                }
            }


            else if (num2 <= num1 && num2 <= num3)
            {
                Console.Write("{0} ", num2);

                if (num1 < num3)
                {
                    Console.Write("{0} {1}", num1, num3);
                }

                else
                {
                    Console.Write("{0} {1}", num3, num1);
                }
            }

            else if (num3 <= num1 && num3 <= num2)
            {
                Console.Write("{0} ", num3);

                if (num1 < num2)
                {
                    Console.Write("{0} {1}", num1, num2);
                }

                else
                {
                    Console.Write("{0} {1}", num2, num1);
                }
            }
        }
    }
}
