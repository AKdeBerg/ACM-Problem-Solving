using System;

namespace Timus1264
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            //long totalSeconds = Int64.Parse(input[0]) * (Int64.Parse(input[1]) + 1);

            Console.WriteLine(Int64.Parse(input[0]) * (Int64.Parse(input[1]) + 1));
            Console.ReadKey();
        }
    }
}
