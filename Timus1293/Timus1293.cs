using System;

namespace Timus1293
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int totalAmount = ((Int32.Parse(input[1]) * Int32.Parse(input[2])) * Int32.Parse(input[0])) * 2;
            Console.WriteLine(totalAmount);
            Console.ReadKey();
        }
    }
}
