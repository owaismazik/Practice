using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.HackerRank
{

//    Anna and Brian are sharing a meal at a restuarant and they agree to split the bill equally.Brian wants to order something that Anna is allergic to though, and they agree that Anna won't pay for that item. Brian gets the check and calculates Anna's portion. You must determine if his calculation is correct.

//For example, assume the bill has the following prices: . Anna declines to eat item which costs.If Brian calculates the bill correctly, Anna will pay.If he includes the cost of, he will calculate.In the second case, he should refund to Anna.

//Function Description

//Complete the bonAppetit function in the editor below.It should print Bon Appetit if the bill is fairly split. Otherwise, it should print the integer amount of money that Brian owes Anna.

//bonAppetit has the following parameter(s):

//bill: an array of integers representing the cost of each item ordered
//k: an integer representing the zero-based index of the item Anna doesn't eat
//b: the amount of money that Anna contributed to the bill
//Input Format

//The first line contains two space-separated integers  and , the number of items ordered and the -based index of the item that Anna did not eat.
//The second line contains  space-separated integers  where.
//The third line contains an integer, , the amount of money that Brian charged Anna for her share of the bill.

//Constraints

//The amount of money due Anna will always be an integer
//Output Format

//If Brian did not overcharge Anna, print Bon Appetit on a new line; otherwise, print the difference(i.e., ) that Brian must refund to Anna.This will always be an integer.

    class Bon_Appétit
    {
        // Complete the bonAppetit function below.
        static void bonAppetit(List<int> bill, int k, int b)
        {
            int result = 0;
            int charged = b;
            int actual = 0;
            int bill_payed = bill[k];
            actual = (bill.Sum() - bill_payed) / 2;
            result = charged - actual;
            if (result == 0)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(result);
            }
        }

        static void Main234234234(string[] args)
        {
            //4 1
            //3 10 2 9
            //7
            string[] nk = "4 1".TrimEnd().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            List<int> bill = "3 10 2 9".TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

            int b = Convert.ToInt32("7".Trim());

            bonAppetit(bill, k, b);
        }
    }
}
