using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.General_Concepts
{
    class PlusMinus
    {
        // Complete the plusMinus function below.
        static void plusMinus(int[] arr)
        {
            double positiveNumbers = 0;
            double positiveResult = 0;
            double negativeNumbers = 0;
            double negativeResult = 0;
            double zeros = 0;
            double zerosResult = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    ++negativeNumbers;
                }
                else if (arr[i] > 0)
                {
                    ++positiveNumbers;
                }
                else
                {
                    ++zeros;
                }
            }
            positiveResult = (double) positiveNumbers / arr.Length;
            negativeResult = (double)negativeNumbers / arr.Length;
            zerosResult = (double)zeros / arr.Length;
            Console.WriteLine(positiveResult);
            Console.WriteLine(negativeResult);
            Console.WriteLine(zerosResult);

        }

        static void Mainggcxc35dfhd(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            plusMinus(arr);
        }
    }
}
