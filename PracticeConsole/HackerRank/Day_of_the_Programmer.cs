using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.HackerRank
{
    class Day_of_the_Programmer
    {
        // Complete the dayOfProgrammer function below.
        static string dayOfProgrammer(int year)
        {
            int feb = 0;
            if (year == 1918)
            {
                string str = string.Empty;
                return "26.09.1918";
            }
            if (year >= 1700 && year <= 1917)
            {
                //Julian_calendar
                // only divide by 4 for leap year
                if (year % 4 == 0)
                {
                    feb = 29;
                }
                else
                {
                    feb = 28;
                }
            }
            if (year >= 1919)
            {
                // Gregorian calendar
                // only divide by 400 and 4 for leap year
                if ((year % 400 == 0) || ((year % 4 == 0) && year%100 != 0))
                {
                    feb = 29;
                }
                else
                {
                    feb = 28;
                }
            }
            int jan = 31;
            int mar = 31;
            int apr = 30;
            int may = 31;
            int jun = 30;
            int jul = 31;
            int aug = 31;
            int sum = jan + feb + mar + apr + may + jun + jul + aug;
            int day = 256 - sum;
            string result = day + ".09." + year;
            return result;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //1800
            //2016
            //2100
            //2017
            //2000
            //1918
            int year = Convert.ToInt32("1918".Trim());

            string result = dayOfProgrammer(year);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
