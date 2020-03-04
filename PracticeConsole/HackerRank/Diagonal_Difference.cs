using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.HackerRank
{
    class Diagonal_Difference
    {

        /*
         * Complete the 'diagonalDifference' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */

        public static int diagonalDifference(List<List<int>> arr)
        {
            var sumPrimaryDiagonal = 0;
            var sumSecondaryDiagonal = 0;
            for (int i = 0, j = arr.Count - 1; i < arr.Count; i++, j--)
            {
                //var newRow = Array.ConvertAll(arr, int.Parse);
                //sumPrimaryDiagonal += newRow[i];
                //sumSecondaryDiagonal += newRow[j];
            }
            //WriteLine(Math.Abs(sumPrimaryDiagonal - sumSecondaryDiagonal));
            return 0;
        }

    }

    class Solution
    {
        public static void Maingfdgn4364ysgh(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Diagonal_Difference.diagonalDifference(arr);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
