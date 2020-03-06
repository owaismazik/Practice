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
            int initial = b[0];
            if (initial == 1 || initial == 0)
            {
                return 0;
            }
            for (int i = 0; i < b.Count; i++)
            {
                if (b[i]% initial == 0)
                {
                    ++result;
                }
            }
            return result;
        }

    }
    class Between_Two_Sets
    {
        public static void Main345345gdf(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            string[] firstMultipleInput = new string[2];
            firstMultipleInput[0] = "2";
            firstMultipleInput[1] = "3";
            //2 3
            //2 4
            //16 32 96

            int n = Convert.ToInt32(firstMultipleInput[0]);
            int m = Convert.ToInt32(firstMultipleInput[1]);
            //List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            List<int> arr = new List<int>();
            arr.Add(2);
            arr.Add(4);
            //List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();
            List<int> brr = new List<int>();
            //1 2 3 4 5 6 7 8 9 10
            //brr.Add(16);
            //brr.Add(32);
            //brr.Add(96);
            brr.Add(1);
            brr.Add(2);
            brr.Add(3);
            brr.Add(4);
            brr.Add(5);
            brr.Add(6);
            brr.Add(7);
            brr.Add(8);
            brr.Add(9);
            brr.Add(10);
            int total = Result2.getTotalX(arr, brr);

            //textWriter.WriteLine(total);
            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
