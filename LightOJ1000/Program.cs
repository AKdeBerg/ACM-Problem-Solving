using System;

namespace LightOJ1000
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= testCase; i++)
            {
              string[] input = Console.ReadLine().Split(' ');
              int sum = Int32.Parse(input[0]) + Int32.Parse(input[1]);
              System.Console.WriteLine($"Case {i}: {sum}");
            }
        }
    }
}
