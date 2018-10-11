using System;

namespace Pyramid02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int space = 1; space < row; space++)
                {
                    System.Console.Write(' ');
                }
                for (int col = n; col >= row; col--)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
            }
        }
    }
}
