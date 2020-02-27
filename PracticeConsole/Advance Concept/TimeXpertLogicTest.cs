using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.Advance_Concept
{
    class TimeXpertLogicTest
    {
        // Objective take integar array like 1,3,5 and return simple integar value like 135
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5 };
            int result = SumResult(arr);
        }

        public static int SumResult(int[] arr)
        {
            string str = "10000000000000";
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i] * Convert.ToInt32(str.Substring(0,arr.Length -i));
            }
            return result;
        }
    }
}
