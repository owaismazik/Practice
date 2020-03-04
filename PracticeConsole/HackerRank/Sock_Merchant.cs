using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.HackerRank
{

//John works at a clothing store.He has a large pile of socks that he must pair by color for sale.Given an array of integers representing the color of each sock, determine how many pairs of socks with matching colors there are.
//For example, there are  socks with colors.There is one pair of color  and one of color . There are three odd socks left, one of each color. The number of pairs is .
//Function Description
//Complete the sockMerchant function in the editor below.It must return an integer representing the number of matching pairs of socks that are available.
//sockMerchant has the following parameter(s):
//n: the number of socks in the pile
//ar: the colors of each sock
//Input Format
//The first line contains an integer , the number of socks represented in .
//The second line contains  space-separated integers describing the colors of the socks in the pile.
//Constraints
// where
//Output Format
//Return the total number of matching pairs of socks that John can sell.
//Sample Input
//9
//10 20 20 10 10 30 50 10 20
//Sample Output
//3

    class Sock_Merchant
    {

        // Complete the sockMerchant function below.
        static int sockMerchant(int n, int[] socksPile)
        {
            var pairsFound = 0;
            var sockColorHash = new Dictionary<int, int>();

            foreach (var sock in socksPile)
            {
                if (sockColorHash.ContainsKey(sock))
                {
                    pairsFound++;
                    sockColorHash.Remove(sock);
                }
                else
                    sockColorHash.Add(sock, 1);
            }
            return pairsFound;
        }

        static void Main4ddgfds(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int n = Convert.ToInt32(Console.ReadLine());
            int n = 9;

            //int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            //10 20 20 10 10 30 50 10 20
            int[] ar = { 10,20,20,10,10,30,50,10,20 };

            int result = sockMerchant(n, ar);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
