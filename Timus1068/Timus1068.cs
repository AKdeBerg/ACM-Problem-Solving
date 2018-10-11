using System;
namespace Timus1068
{
    class Program
    {
        static void Main(string[] args)
        {
            long aNumber = Convert.ToInt64(Console.ReadLine());
            long sum = 0;
            if (aNumber > 0)
            {
                for (long i = aNumber; i >= 1; i--)
                {
                    sum += i;
                }
            }
            //else if (aNumber == 0)
            //{
            //    sum = 0;
            //}
            else 
            {
                for (long i = aNumber; i <= 1; i++)
                {
                    sum += i;
                }
            }


            Console.WriteLine("{0}", sum);

            //Console.ReadKey();
        }
    }
}
