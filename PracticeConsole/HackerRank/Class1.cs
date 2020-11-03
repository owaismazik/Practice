using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.HackerRank
{
    class Class1
    {


        //string value = Console.ReadKey();
        string value = string.Empty;

        
        static void Main(string[] args)
        {
            string value = Console.ReadLine();
            //you can also check value.length and redirect if length greater than 2
            if (value.Length > 2)
            {
                Console.WriteLine("Please enter correct value");
                return;
            }
            if (value.Contains("Your Number"))
            {
                if (value.Contains("Your Letter"))
                {
                    //your code goes here
                }
                else
                {
                    Console.WriteLine("Please Enter Correct Value");
                }
            }
            else
            {
                Console.WriteLine("Please Enter Correct Value");
            }
        }
    }
}
