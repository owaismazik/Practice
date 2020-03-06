using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.HackerRank
{
    class Breaking_The_Records
    {
        // Complete the breakingRecords function below.
        static int[] breakingRecords(int[] scores)
        {
            int[] result = new int[2];
            int minScoreCount = 0;
            int maxScoreCount = 0;
            int minValue = scores[0];
            int maxValue = scores[0];
            //int currentValue = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > maxValue)
                {
                    maxValue = scores[i];
                    ++maxScoreCount;
                }
                if (scores[i] < minValue)
                {
                    minValue = scores[i];
                    ++minScoreCount;
                }
            }
            result[0] = maxScoreCount;
            result[1] = minScoreCount;
            return result;
        }

        static void Main234234fgdfg(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int n = Convert.ToInt32(Console.ReadLine());
            //10
            int n = 9;
            //int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));
            //10 5 20 20 4 5 2 25 1
            int[] scores = { 10 , 5 , 20 , 20 , 4 , 5 , 2 , 25 , 1 };
            //3 4 21 36 10 28 35 5 24 42
            //int[] scores = { 3 , 4 , 21 , 36 , 10 , 28 , 35 , 5 , 24 , 42 };

            int[] result = breakingRecords(scores);

            //textWriter.WriteLine(string.Join(" ", result));
            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
