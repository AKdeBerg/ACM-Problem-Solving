using System;

namespace Timus1086_Sieve
{
    class Program
    {
        public static int[] arrayOfPrime = new int[15000+1];
        static void Main(string[] args)
        {
            int numOfInputs = Convert.ToInt32(Console.ReadLine());
            long[] input = new long[numOfInputs];

            //taking input
            int i = 0;
            while (i != numOfInputs)
            {
                input[i] = Convert.ToInt64(Console.ReadLine());
                i++;
            }
            SievePrime();
            for (int k = 0; k < input.Length; k++)
            {
                System.Console.WriteLine(arrayOfPrime[input[k]-1]);
            }

        }

        
        static void SievePrime()
        {
            bool[] primeList = new bool[163842]; 

            

            primeList[0] = false;
            primeList[1] = false;       
          
            //assuming every other elements are prime
            for (int i = 2; i <= 163841; i++)
            {
                primeList[i] = true;
            }    

           
            //marking the multiples of each number as not prime
            for (int i = 2; i*i <= 163841; i++)
            {
                if (primeList[i])
                {
                    //setting multiples of the number to false 
                    for (int mul = 2; mul * i <= 163841; mul++)
                    {
                        primeList[i*mul] = false;
                    }
                }

            } 

            int index = 0;
            //copy only prime numbers
            for (int i = 2; i <= 163841; i++)
            {
                if (primeList[i])
                {
                    arrayOfPrime[index] = i;
                    index++;
                }
            }

           
        }
    }
}
