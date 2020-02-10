using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class OpenCloseBrackets
    {
        static void Main232dfdfd()
        {
            try
            {
                string str = "((())(())))";
                Stack<char> stk = new Stack<char>();
                foreach (char item in str)
                {
                    if (item == '(')
                    {
                        stk.Push(item);
                    }
                    else if (item == ')')
                    {
                        stk.Pop();
                    }
                }

                if (stk.Count > 0)
                {
                    Console.WriteLine("Wrong Data Entered");
                }
                else
                {
                    Console.WriteLine("Proper Data Formated");
                }

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wrong Data Entered");
                Console.WriteLine("-------------");
                Console.WriteLine(ex.Message);
                Console.WriteLine("-------------");
                Console.ReadKey();
            }
        }
    }
}
