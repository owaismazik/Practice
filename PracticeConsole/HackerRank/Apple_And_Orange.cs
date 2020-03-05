using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.HackerRank
{
    class Apple_And_Orange
    {

        // Complete the countApplesAndOranges function below.
        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            //s and t is the range
            //a is apple
            //b is orange
            int countApple = 0;
            int countOrange = 0;
            List<int> apple = new List<int>();
            List<int> orange = new List<int>();
            for (int i = 0; i < apples.Length; i++)
            {
                apple.Add(a + apples[i]);
                if (s <= apple[i] && t >= apple[i])
                {
                    ++countApple;
                }
                //else if (t <= apple[i])
                //{
                //    ++countApple;
                //}
            }
            for (int i = 0; i < oranges.Length; i++)
            {
                orange.Add(b + oranges[i]);
                if (s <= orange[i] && t >= orange[i])
                {
                    ++countOrange;
                }
                //else if (t <= orange[i])
                //{
                //    ++countOrange;
                //}
            }
            Console.WriteLine(countApple);
            Console.WriteLine(countOrange);
        }

        static void Main4343fgdfgdf(string[] args)
        {
            //string[] st = Console.ReadLine().Split(' ');
            //7 11
            string[] st = new string[2];
            st[0] = "7";
            st[1] = "11";

            int s = Convert.ToInt32(st[0]);

            int t = Convert.ToInt32(st[1]);

            //string[] ab = Console.ReadLine().Split(' ');
            string[] ab = new string[2];
            ab[0] = "5";
            ab[1] = "15";
            //5 15

            int a = Convert.ToInt32(ab[0]);

            int b = Convert.ToInt32(ab[1]);

            //string[] mn = Console.ReadLine().Split(' ');
            string[] mn = new string[2];
            mn[0] = "3";
            mn[1] = "2";
            //3 2

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            //int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp));
            int[] apples = {-2,2,1};

            //int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp));
            int[] oranges = {5,-6};

            countApplesAndOranges(s, t, a, b, apples, oranges);
        }
    }
}
