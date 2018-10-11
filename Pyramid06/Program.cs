using System;

namespace Pyramid06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            //upper rows
            for (int row = 1; row <= n; row++)
            {
                //space
                for (int space = n - row; space >= 1; space--)
                {
                    Console.Write(' ');
                }

                //nums increasing
                for (int num = 1; num <= row; num++)
                {
                    Console.Write(num);
                }

                //nums decreasing
                for (int num = row - 1; num >= 1; num--)
                {
                    Console.Write(num);
                }
                System.Console.WriteLine();
            }

            //lower rows
            for (int row = n-1; row >= 1; row--)
            {
                //space
                for (int space = 1; space <= n - row; space++)
                {
                    Console.Write(' ');
                }

                //nums increasing
                for (int num = 1; num <= row; num++)
                {
                    Console.Write(num);
                }

                //nums decreasing
                for (int num = row - 1; num >= 1; num--)
                {
                    Console.Write(num);
                }
                System.Console.WriteLine();
            }
        }
    }
}
