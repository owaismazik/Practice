using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.Logic_Building
{
class HackerRankBracketBalance
    {

        // Complete the isBalanced function below.
        static string isBalanced(string s)
        { 
                bool value = true;
                for (int i = 0; i < s.Length/2; i++)
                {
                if (value == false)
                {
                    break;
                }
                    for (int j = s.Length-1-i; j >= s.Length / 2; j--)
                    {
                        if ((s[i] == '{' && s[j] == '}') || (s[i] == '[' && s[j] == ']') || (s[i] == '(' && s[j] == ')'))
                        {
                            value = true;
                        }
                        else
                        {
                            value = false;
                            break;
                        }
                        break;
                    }
                }
                if (value)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }


        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int t = Convert.ToInt32(Console.ReadLine());

            //for (int tItr = 0; tItr < t; tItr++)
            //{
                string s = "{[()]}";

                string result = isBalanced(s);
                Console.WriteLine(result);
                //textWriter.WriteLine(result);
            //}

            //textWriter.Flush();
            //textWriter.Close();
        }
    }

}
