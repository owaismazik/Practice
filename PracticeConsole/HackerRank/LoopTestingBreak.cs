using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.HackerRank
{
    class LoopTestingBreak
    {
        static void Main4564(string[] args)
        {
            int counter = 0;
            bool breaker = false;
            for (int i = 0; i < 5; i++)
            {
                if (breaker == true)
                {
                    break;
                }
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine(++counter);
                    if (j == 1)
                    {
                        breaker = true;
                        break;
                    }
                }
            }
        }
    }
}
