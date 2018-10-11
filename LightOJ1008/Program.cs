using System;

namespace LightOJ1008
{
    class Program
    {
        public static long x, y;
        static void Main(string[] args)
        {
            int testCase = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= testCase; i++)
            {
                //take a number s 
                long s =  Convert.ToInt64(Console.ReadLine());
                findTheLight(s, i);
            }
        }

        static void findTheLight(long s, int i)
        {
            long val = (long)Math.Sqrt(s);
            if (val*val < s)
            {
                val += 1;
            }
            //this val is the either row or coloumn number for the given s
                //to find specifically whether the val means row or coloumn we need to do the following operating
                long middlePointOfTheval = (val * val) - (val - 1);
                long differenceBetweenMiddlePointandGivenS = Math.Abs(s - middlePointOfTheval);
                //check if the val is in odd zone or even zone. I mean check if the square root is even or odd
                if (val % 2 != 0)
                {
                    if (s > middlePointOfTheval)
                    {
                        x = val - differenceBetweenMiddlePointandGivenS;
                        y = val;
                    }
                    else if (s == middlePointOfTheval)
                    {
                        x = val;
                        y = val;
                    }
                    else if (s < middlePointOfTheval)
                    {
                        x = val;
                        y = val - differenceBetweenMiddlePointandGivenS;
                    }
                }

                else
                {
                    if (s < middlePointOfTheval)
                    {
                        x = val - differenceBetweenMiddlePointandGivenS;
                        y = val;
                    }
                    else if (s == middlePointOfTheval)
                    {
                        //System.Console.WriteLine($"{val} {val}");
                        x = val;
                        y = val;
                    }
                    else if (s > middlePointOfTheval)
                    {
                        
                        x = val;
                        y = val - differenceBetweenMiddlePointandGivenS;
                    }
                }

                System.Console.WriteLine($"Case {i}: {x} {y}");
        }
    }
}
