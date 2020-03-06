using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.HackerRank
{
    class Kangaroo
    {

        // Complete the kangaroo function below.
        static string kangaroo(int x1, int v1, int x2, int v2)
        {
            string result = string.Empty;
            //int diffKangoro1 = Math.Abs(x1 - v1);
            //int diffKangoro2 = Math.Abs(x2 - v2);
            //if (diffKangoro1 != diffKangoro2)
            //{
            //    result = "YES";
            //}
            //else if (diffKangoro1 == diffKangoro2)
            //{
            //    result = "NO";
            //}
            int valueKangoro1 = x1;
            int valueKangoro2 = x2;
            for (int i = 0; i < 10000; i++)
            {
                valueKangoro1 = valueKangoro1 + v1;
                valueKangoro2 = valueKangoro2 + v2;
                if (valueKangoro1 == valueKangoro2)
                {
                    result = "YES";
                    break;
                }
            }
            if (string.IsNullOrEmpty(result))
            {
                result = "NO";
            }
            return result;
        }

        static void Mainvbvbd434s(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //string[] x1V1X2V2 = Console.ReadLine().Split(' ');
            //0 2 5 3
            //21 6 47 3
            //4523 8092 9419 8076
            //2081 8403 9107 8400
            string[] x1V1X2V2 = new string[4];
            x1V1X2V2[0] = "2081";
            x1V1X2V2[1] = "8403";
            x1V1X2V2[2] = "9107";
            x1V1X2V2[3] = "8400";

            int x1 = Convert.ToInt32(x1V1X2V2[0]);

            int v1 = Convert.ToInt32(x1V1X2V2[1]);

            int x2 = Convert.ToInt32(x1V1X2V2[2]);

            int v2 = Convert.ToInt32(x1V1X2V2[3]);

            string result = kangaroo(x1, v1, x2, v2);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
