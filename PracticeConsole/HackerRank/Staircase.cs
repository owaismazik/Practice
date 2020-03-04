using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.HackerRank
{
    class Staircase
    {
        //#
        //##
        //###
        //####
        //#####
        //######
        // Complete the staircase function below.
        static void staircase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n-1-i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#"); 
                }
                Console.WriteLine();
            }

        }

        static void Maindfdfdf353sdgs(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
        }
    }
}
