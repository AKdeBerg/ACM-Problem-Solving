using System;

namespace Pyramid01
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a number: ");
            int n = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine();
            
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
            }
        }
    }
}
