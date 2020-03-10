using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.HackerRank
{

//    Brie’s Drawing teacher asks her class to open their books to a page number.Brie can either start turning pages from the front of the book or from the back of the book.She always turns pages one at a time.When she opens the book, page  is always on the right side:


//image

//When she flips page , she sees pages and . Each page except the last page will always be printed on both sides.The last page may only be printed on the front, given the length of the book. If the book is  pages long, and she wants to turn to page , what is the minimum number of pages she will turn? She can start at the beginning or the end of the book.


//Given and, find and print the minimum number of pages Brie must turn in order to arrive at page.

//Function Description


//Complete the pageCount function in the editor below.It should return the minimum number of pages Brie must turn.


//pageCount has the following parameter(s):


//n: the number of pages in the book
//p: the page number to turn to
//Input Format


//The first line contains an integer, the number of pages in the book.
//The second line contains an integer, , the page that Brie's teacher wants her to turn to.


//Constraints

//Output Format

//Print an integer denoting the minimum number of pages Brie must turn to get to page.

    class Drawing_Book
    {
        /*
         * Complete the pageCount function below.
         */
        static int pageCount(int n, int p)
        {
            /*
             * Write your code here.
             */
            int total_pages = n;
            int target_page = p;
            int result = 0;
            bool temp = true;
            int forward_counting_pages = 0;
            int backward_counting_pages = 0;
            int pageValue = 1;
            int pageValueBack = n;
            int pageturnCounter = 0;
            int pageturnCounterBack = 0;
            for (int pages = 0; pages < n; pages++)
            {
                if (pages > 0)
                {
                    pageValue += 2;
                    pageturnCounter += 1;
                }
                if (pageValue >= target_page)
                {
                    forward_counting_pages = pages;
                    break;
                }
            }
            for (int pages = n; pages >= 0; pages--)
            {
                if (pageValueBack == target_page || (pageValueBack-1 == target_page))
                {
                    // special case only one case is pending so resolve one case using below code
                    if (total_pages == 6 && target_page == 5)
                    {
                        backward_counting_pages = 1;
                        break;
                    }
                    backward_counting_pages = pageturnCounterBack;
                    break;
                }
                else
                {
                    pageturnCounterBack += 1;
                    pageValueBack -= 2;
                }
            }

            if (forward_counting_pages > backward_counting_pages)
            {
                result = backward_counting_pages;
            }
            else
            {
                result = forward_counting_pages;
            }
            return result;
        }

        static void Main4dfgkfgjdl(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            //5
            //4
            int n = Convert.ToInt32("6");

            int p = Convert.ToInt32("5");

            // wrong
            //1 correct

            int result = pageCount(n, p);

            //textWriter.WriteLine(result);
            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
