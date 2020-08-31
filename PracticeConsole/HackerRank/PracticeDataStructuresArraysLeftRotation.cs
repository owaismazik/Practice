using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.HackerRank
{
    class PracticeDataStructuresArraysLeftRotation
    {
        static void Mainfsff(string[] args)
        {
            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

            int[] b = new int[a.Length];

                for (int j = 0; j < n; j++)
                {
                    int newIndex = (j + n - d) % n;
                    b[newIndex] = a[j];
                }
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i] + " ");
            }
        }
    }
}
