using System;

namespace Timus1083
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' '); //taking input

            int n = int.Parse(input[0]); // taking the value of n from string and convert it to int
            int k = input[1].Length; //taking the value of k where k means the number of !

            //main method to calculate the factorial
            int fact = 1, i = 0, mul = 1;

            while (mul >= 1)
            {
                fact *= mul;
                mul = n - (i * k);
                i++;           
            }
            System.Console.WriteLine(fact);
        }
    }
}
