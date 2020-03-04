using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.HackerRank
{
    class Time_Conversion
    {
        enum ClockTime
        {
            one = 13,
            two = 14,
            three = 15,
            four = 16,
            five = 17,
            six = 18,
            seven = 19,
            eight = 20,
            nine = 21,
            ten = 22,
            eleven = 23,
            twelve = 12
        }
        /*
         * Complete the timeConversion function below.
         */
        static string timeConversion(string s)
        {
            string[] str = s.Replace("PM", "").Split(':');
            string hour = string.Empty;
            if (s.Contains("AM"))
            {
                if (str[0] == "12")
                {
                    s = s.Replace("12", "00");
                }
                return s.Replace("AM", "");
            }
            else if (s.Contains("PM"))
            {
                //07:05:45PM
                switch (Convert.ToInt32(str[0]))
                {
                    case 1:
                        hour = Convert.ToString(Convert.ToInt32(ClockTime.one));
                        break;
                    case 2:
                        hour = Convert.ToString(Convert.ToInt32(ClockTime.two));
                        break;
                    case 3:
                        hour = Convert.ToString(Convert.ToInt32(ClockTime.three));
                        break;
                    case 4:
                        hour = Convert.ToString(Convert.ToInt32(ClockTime.four));
                        break;
                    case 5:
                        hour = Convert.ToString(Convert.ToInt32(ClockTime.five));
                        break;
                    case 6:
                        hour = Convert.ToString(Convert.ToInt32(ClockTime.six));
                        break;
                    case 7:
                        hour = Convert.ToString(Convert.ToInt32(ClockTime.seven));
                        break;
                    case 8:
                        hour = Convert.ToString(Convert.ToInt32(ClockTime.eight));
                        break;
                    case 9:
                        hour = Convert.ToString(Convert.ToInt32(ClockTime.nine));
                        break;
                    case 10:
                        hour = Convert.ToString(Convert.ToInt32(ClockTime.ten));
                        break;
                    case 11:
                        hour = Convert.ToString(Convert.ToInt32(ClockTime.eleven));
                        break;
                    case 12:
                        hour = Convert.ToString(Convert.ToInt32(ClockTime.twelve));
                        break;
                    //12:40:22AM
                    //12:45:54PM
                    //12:45:54
                    default:
                        hour = string.Empty;
                        break;
                }
            }
            if (hour.Length < 2)
            {
                hour += "0";
            }
            return hour +":"+ str[1] +":"+ str[2];
        }

        static void Main(string[] args)
        {
            //TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            string s = Console.ReadLine();
            string result = timeConversion(s);
            //tw.WriteLine(result);
            //tw.Flush();
            //tw.Close();
        }
    }
}
