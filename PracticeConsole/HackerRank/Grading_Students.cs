using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.HackerRank
{
    class Result
    {

        /*
         * Complete the 'gradingStudents' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY grades as parameter.
         */

        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> result = new List<int>();
            foreach (var item in grades)
            {
                if (item > 37)
                {
                    string str = Convert.ToString(item);
                    str = str.Substring(str.Length - 1, 1);
                    if (str == "3" || str == "8")
                    {
                        result.Add(item + 2);
                    }
                    else if (str == "4" || str == "9")
                    {
                        result.Add(item + 1);
                    }
                    else if (str == "1" || str == "2" || str == "6" || str == "7" || str == "5")
                    {
                        result.Add(item);
                    }
                    else if (str == "0" || str == "5")
                    {
                        result.Add(item);
                    }
                }
                else
                {
                    result.Add(item);
                }
            }
            return result;
        }

    }
    class Grading_Students
    {
        public static void Main657567fhfhg(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = Result.gradingStudents(grades);
            //4
            //73
            //67
            //38
            //33
            //textWriter.WriteLine(String.Join("\n", result));
            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
