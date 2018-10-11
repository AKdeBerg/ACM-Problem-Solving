using System;

namespace timus1086
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeFound = 0, number = 0;

            int numOfInputs = Convert.ToInt32(Console.ReadLine());
            int[] input = new int[numOfInputs];

            //taking input
            int i = 0;
            while (i != numOfInputs)
            {
                input[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }
            
            for (int k = 0; k < input.Length; k++)
            {
                    while (primeFound != input[k])
                    {
                        if (CheckIfPrime(number))
                        {
                            primeFound++;
                        }

                        number++;
                    }

            System.Console.WriteLine(number - 1);
            }

        }

        //a method to check if the number is prime
        
        static bool CheckIfPrime(int num)
        {
            
            if (num <= 1)
            {
                return false;
            }

            for (int i = 2; i < num; i++)
            {
                if (num%i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
