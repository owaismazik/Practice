using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.HackerRank
{
    class Divisible_Sum_Pairs
    {
        // Complete the divisibleSumPairs function below.
        static int divisibleSumPairs(int n, int k, int[] ar)
        {
            int countPairs = 0;
            int divide = k;
            int initialValue = ar[0];
            int sum = 0;
            for (int j = 0; j < ar.Length; j++)
            {
                initialValue = ar[j];
                for (int i = 1; i < ar.Length - j; i++)
                {
                    sum = initialValue + ar[i+j];
                    if (sum%divide == 0)
                    {
                        ++countPairs;
                    }
                    sum = 0;
                } 
            }
            return countPairs;
        }

        static void Main242424(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            //6 3
            //1 3 2 6 1 2
            //5

            //string[] nk = Console.ReadLine().Split(' ');
            string[] nk = "6 3".Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            //int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int[] ar = Array.ConvertAll("1 3 2 6 1 2".Split(' '), arTemp => Convert.ToInt32(arTemp));

            int result = divisibleSumPairs(n, k, ar);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
