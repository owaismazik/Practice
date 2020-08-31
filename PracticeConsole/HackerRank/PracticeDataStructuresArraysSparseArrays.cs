using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.HackerRank
{
    class PracticeDataStructuresArraysSparseArrays
    {
        static int[] matchingStrings(string[] strings, string[] queries)
        {
            int[] abc = new int[strings.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                int counter = 0;
                for (int j = 0; j < strings.Length; j++)
                {
                    if (queries[i] == strings[j])
                    {
                        abc[i] = ++counter;
                    }
                }
            }
            return abc;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int stringsCount = Convert.ToInt32(Console.ReadLine());

            //string[] strings = new string[stringsCount];
            string[] strings = { "def", "de", "fgh" };

            //for (int i = 0; i < stringsCount; i++)
            //{
            //    string stringsItem = Console.ReadLine();
            //    strings[i] = stringsItem;
            //}

            //int queriesCount = Convert.ToInt32(Console.ReadLine());

            //string[] queries = new string[queriesCount];
            string[] queries = { "de","lmn","fgh"};

            //for (int i = 0; i < queriesCount; i++)
            //{
            //    string queriesItem = Console.ReadLine();
            //    queries[i] = queriesItem;
            //}

            int[] res = matchingStrings(strings, queries);

            //textWriter.WriteLine(string.Join("\n", res));

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
