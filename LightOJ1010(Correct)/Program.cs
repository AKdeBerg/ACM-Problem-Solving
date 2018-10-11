using System;

namespace LightOJ1010_Correct_
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            //enter the number of testcase
            int testcase = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= testcase; i++)
            {
                //enter the row and col number
            string[] input = (Console.ReadLine().Split(' '));
            
            int row = Convert.ToInt32(input[0]);
            int col = Convert.ToInt32(input[1]);

            //special case for 1
            if (row == 1 || col == 1) result = row * col;

            //special case for 2
            else if (row == 2 || col == 2)
            {
                if (col == 2)
                {
                    int temp = row;
                    row = col;
                    col = temp;
                }

                if (row == 2)
                {
                    if (col % 4 < 2) result = (col / 4) * 4 + (col % 4) * 2;
                    
                    else  result = (col / 4) * 4 + 4;
                }
            }

            //general case
            else result = (row * col + 1) / 2;

            System.Console.WriteLine($"Case {i}: {result}");
            }
        }
    }
}
