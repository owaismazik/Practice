using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.HackerRank
{
    class Mini_Max_Sum
    {
        // Complete the miniMaxSum function below.
        static void miniMaxSum(int[] arr)
        {
            long MinSum = 0;
            long MaxSum = 0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                MinSum += arr[i];
                MaxSum += arr[i+1];
            }
            Console.WriteLine(MinSum + " " + MaxSum);

        }

        static void Main4444464646743(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            Array.Sort(arr);
            miniMaxSum(arr);
        }
    }
}
