using System;

namespace Pyramid03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of rows: ");
            int n = Convert.ToInt32(System.Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                //space
                for (int space = n - row ; space >= 1; space--)
                {
                    System.Console.Write(' ');
                }

                //asteric
                for (int col = 1; col <= (row * 2) - 1; col++)
                {
                    System.Console.Write("*");
                }

                System.Console.WriteLine();
            }
        }
    }
}
