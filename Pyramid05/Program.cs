using System;

namespace Pyramid05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            //Console.WriteLine();
            //for upper part
            for (int row = 1; row <= n; row++)
            {
                //space
                for (int space = n - row; space >= 1; space--)
                {
                    Console.Write(' ');
                }

                //asteric
                for (int col = 1; col <= (row * 2) - 1; col++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            //for lower part
            int aVar = n - 1;
           
            for (int row = aVar; row >= 1; row--)
            {
                 
                //space
                for (int space = 1; space <= n - row ; space++)
                {
                    Console.Write(' ');                    
                }

                //asteric
                for (int col = (row * 2)-1; col >= 1; col--)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
