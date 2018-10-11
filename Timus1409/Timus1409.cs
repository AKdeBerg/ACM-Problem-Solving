using System;

namespace Timus1409
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int totalCan = ((int.Parse(input[0]) - 1)
                 +(int.Parse(input[1]) - 1)
                ) + 1;

            Console.WriteLine("{0} {1}",totalCan - int.Parse(input[0]), totalCan - int.Parse(input[1]));
            Console.ReadKey();
        }
    }
}
