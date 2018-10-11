using System;

namespace Pyramid04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine();
            for (int row = n; row >= 1 ; row--)
            {
                //for space
                for (int space = 1; space <= (n - row); space++)
                {
                    System.Console.Write(' ');
                }

                //for increasing num
                for (int num = 1; num <= row; num++)
                {
                    Console.Write(num);
                }

                //for decreasing num
                
                for (int num = row -1; num >= 1; num--)
                {
                    Console.Write(num);
                }
                System.Console.WriteLine();
            }
        }
    }
}
