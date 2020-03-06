using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.HackerRank
{
    class Birthday_Chocolate
    {
        // Complete the birthday function below.
        static int birthday(List<int> s, int d, int m)
        {
            int result = 0;
            int sum = 0;
            int targetSum = d;
            int sumCounter = 0;
            int consuctiveSquare = m;
            for (int i = 0; i < s.Count; i++)
            {
                ++sumCounter;
                if (sumCounter <= consuctiveSquare)
                {
                    sum += s[i]; 
                    if (targetSum == sum && sumCounter == consuctiveSquare)
                    {
                        ++result;
                        if (s.Count > 1)
                        {
                            sum = sum - s[i + 1 - sumCounter];
                            sumCounter -= 1;
                        }
                    }
                    else if (sumCounter == consuctiveSquare)
                    {
                        if (s.Count > 1)
                        {
                            sum = sum - s[i + 1 - sumCounter]; 
                        }
                        sumCounter -= 1;
                    }
                }

            }

            return result;
        }

        static void Maindfgfdgdf43534(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            //5
            //1 2 1 3 2
            //3 2

            //13
            //4 5 4 2 4 5 2 3 2 1 1 5 4
            //15 4

            //1
            //4
            //4 1

            //19
            //2 5 1 3 4 4 3 5 1 1 2 1 4 1 3 3 4 2 1
            //18 7

            //2 5 1 3 4 4 3 = 22
            //5 1 3 4 4 3 5 = 23
            //3 4 4 3 5 1 1 = 19
            //4 4 3 5 1 1 2 = 18
            //1 3 4 4 3 5 1 1 2 1 4 1 3 3 4 2 1
            //1 3 4 4 3 5 1 1 2 1 4 1 3 3 4 2 1
            //1 3 4 4 3 5 1 1 2 1 4 1 3 3 4 2 1
            //1 3 4 4 3 5 1 1 2 1 4 1 3 3 4 2 1

            //4 5 4 5 1 2 1 4 3 2 4 4 3 5 2 2 5 4 3 2 3 5 2 1 5 2 3 1 2 3 3 1 2 5
            //18 6

            //int n = Convert.ToInt32(Console.ReadLine().Trim());
            int n = 19;

            //List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();
            List<int> s = "4 5 4 5 1 2 1 4 3 2 4 4 3 5 2 2 5 4 3 2 3 5 2 1 5 2 3 1 2 3 3 1 2 5".TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            //string[] dm = Console.ReadLine().TrimEnd().Split(' ');
            string[] dm = "18 6".TrimEnd().Split(' ');

            int d = Convert.ToInt32(dm[0]);

            int m = Convert.ToInt32(dm[1]);

            int result = birthday(s, d, m);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
