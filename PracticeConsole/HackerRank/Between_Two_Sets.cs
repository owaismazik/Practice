using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.HackerRank
{
    class Result2
    {

        /*
         * Complete the 'getTotalX' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY a
         *  2. INTEGER_ARRAY b
         */

        public static int getTotalX(List<int> a, List<int> b)
        {
            int result = 0;

            return result;
        }

    }
    class Between_Two_Sets
    {
        public static void Main56565(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] firstMultipleInput = "2 3".TrimEnd().Split(' ');
            //2 3
            //2 4
            //16 32 96
            int n = Convert.ToInt32(firstMultipleInput[0]);
            int m = Convert.ToInt32(firstMultipleInput[1]);
            List<int> arr = "2 4".TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            List<int> brr = "16 32 96".TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();
            int total = Result2.getTotalX(arr, brr);

            //textWriter.WriteLine(total);
            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
