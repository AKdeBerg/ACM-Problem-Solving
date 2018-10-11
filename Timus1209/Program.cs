using System;

namespace Timus1209
{
    class Program
    {
        static void Main(string[] args)
        {
            //taking n
            long n = Convert.ToInt64(Console.ReadLine());

            //taking kth position
            long[] input = new long[n];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = Convert.ToInt64(Console.ReadLine());
            }


            //THIS IS THE MAIN PART OF THE PROGRAM: YOU HAVE TO UNDERSTAND THE THEORY BEHIND THIS LOGIC
                //at frist watch this video about number sequence: https://www.youtube.com/watch?v=FfCq7bGAFoY&t=197s
                //then read this article: https://binaryarchives.wordpress.com/2014/06/22/1-10-100-1000-1209-c/

                
            //check for every input[i] whether n is a whole number or not
            //Here, n = (Math.Sqrt(8*input[i] - 7) - 1) / 2;
            for (int i = 0; i < input.Length; i++)
            {
                double xInDouble = 0;
                long xInInt = 0;

                xInDouble = (Math.Sqrt(8*input[i] - 7) - 1) / 2;
                xInInt = (int)xInDouble;

                //checking the value of x whether a whole number or not;
                //if it is a whole number then the answer will be 1, else it'll be 0
                if (xInInt == xInDouble)
                {
                    System.Console.Write("1 ");
                }
                else
                {
                    System.Console.Write("0 ");
                }
            }
        }
    }
}
