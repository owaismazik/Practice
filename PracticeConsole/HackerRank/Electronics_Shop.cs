using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.HackerRank
{
    class Electronics_Shop
    {
        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            Array.Sort(keyboards);
            Array.Sort(drives);
            int total_money = b;
            int max_value_purchase_result = -1;
            foreach (var keyboard in keyboards)
            {
                foreach (var drive in drives)
                {
                    if (drive+keyboard <= total_money)
                    {
                        if (drive+keyboard > max_value_purchase_result)
                        {
                            max_value_purchase_result = drive + keyboard;
                        }
                    }
                }
            }
            return max_value_purchase_result;
        }

        static void Main(string[] args)
        {
            //10 2 3
            //3 1
            //5 2 8
            //9
            //---------------
            //5 1 1
            //4
            //5
            //0
            //--------------
            //839979 716 867
            string[] bnm = "10 2 3".Split(' ');
            int b = Convert.ToInt32(bnm[0]);
            int n = Convert.ToInt32(bnm[1]);
            int m = Convert.ToInt32(bnm[2]);
            int[] keyboards = Array.ConvertAll("3 1".Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp));
            int[] drives = Array.ConvertAll("5 2 8".Split(' '), drivesTemp => Convert.ToInt32(drivesTemp));
            /*
             * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
            */

            int moneySpent = getMoneySpent(keyboards, drives, b);
        }
    }
}
