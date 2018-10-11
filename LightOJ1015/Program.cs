using System;

namespace LightOJ1015
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, aVal = 0;
            int testCase = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= testCase; i++)
            {
                Console.WriteLine();
                int numOfStudents = Int32.Parse(Console.ReadLine());
                String[] input = Console.ReadLine().Split(' ');
                for(int n = 0; n < numOfStudents; n++)
                {
                    aVal = Int32.Parse(input[n]);
                    if (aVal < 0) aVal = 0;

                    sum += aVal;
                }
                System.Console.WriteLine($"Case {i}: {sum}");
                sum = 0;
            }
        }
    }
}
