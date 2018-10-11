using System;

namespace LightOJ1001
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = Convert.ToInt32(Console.ReadLine());
            int n = 0,index = 0;
            int[] num = new int[50];

            for (int i = 1; i <= testCase; i++)
            {
                n = Convert.ToInt32(Console.ReadLine());
                num[index] = n / i;
                if (num[index] > 10)
                {
                    num[index] = 10;
                }
                num[index+1] = n - num[index]; 
                if (num[index+1] > 10)
                {
                    num[index] = 10;
                    num[index+1] = n - num[index];
                }
                                
                index += 2;
            }

           index = 0;
           while (index < testCase*2)
           {
               Console.Write($"{num[index]} {num[index+1]}");
               
               System.Console.WriteLine();
               index += 2;
           }
        }
    }
}
