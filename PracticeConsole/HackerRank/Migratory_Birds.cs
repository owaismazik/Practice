using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.HackerRank
{
    class Migratory_Birds
    {

        // Complete the migratoryBirds function below.
        static int migratoryBirds(List<int> arr)
        {
            int result = 0;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            arr.Sort();
            int valueCounter = 0;
            int smallestValueHighestCounter = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (!dic.ContainsKey(arr[i]))
                {
                    valueCounter = 0;
                    dic.Add(arr[i], ++valueCounter);
                }
                else if (dic.ContainsKey(arr[i]))
                {
                    dic[arr[i]] = ++valueCounter;
                    if (valueCounter > smallestValueHighestCounter)
                    {
                        smallestValueHighestCounter = valueCounter;
                        result = arr[i];
                    }
                }
            }
            return result;
        }

        static void Main34543534ghfgh(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //11
            //1 2 3 4 5 4 3 2 1 3 4
            //3

            int arrCount = Convert.ToInt32("11".Trim());

            List<int> arr = "1 2 3 4 5 4 3 2 1 3 4".TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = migratoryBirds(arr);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
