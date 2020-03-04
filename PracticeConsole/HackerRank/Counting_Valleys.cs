using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.HackerRank
{
    //Gary is an avid hiker.He tracks his hikes meticulously, paying close attention to small details like topography.During his last hike he took exactly  steps.For every step he took, he noted if it was an uphill, , or a downhill, step.Gary's hikes start and end at sea level and each step up or down represents a  unit change in altitude. We define the following terms:
    //A mountain is a sequence of consecutive steps above sea level, starting with a step up from sea level and ending with a step down to sea level.
    //A valley is a sequence of consecutive steps below sea level, starting with a step down from sea level and ending with a step up to sea level.
    //Given Gary's sequence of up and down steps during his last hike, find and print the number of valleys he walked through.
    //For example, if Gary's path is , he first enters a valley  units deep. Then he climbs out an up onto a mountain  units high. Finally, he returns to sea level and ends his hike.
    //Function Description
    //Complete the countingValleys function in the editor below.It must return an integer that denotes the number of valleys Gary traversed.
    //countingValleys has the following parameter(s):
    //n: the number of steps Gary takes
    //s: a string describing his path
    //Input Format
    //The first line contains an integer, the number of steps in Gary's hike.
    //The second line contains a single string , of characters that describe his path.
    //Constraints
    //Output Format
    //Print a single integer that denotes the number of valleys Gary walked through during his hike.
    //Sample Input
    //8
    //UDDDUDUU
    //Sample Output
    //1

    /*
Problem: https://www.hackerrank.com/challenges/counting-valleys
C# language Version: 6.0
.Net Framework Version: 4.5.2
Thoughts: 
1. Set a counter seaLevel to 0.
2. Set a boolean isValleyActive to false.
3. Set a counter valleyCount to 0.
4. After every step:
    2.1 increment the seaLevel by 1 if it is uphill step and decrement it by 1 if it is a downhill step.
    2.2 If there is no valley currently active(i.e. isValleyActive was false until this step) and if seaLevel 
    has become negative after current step means we have started traversing a valley then set the boolean 
    isValleyActive to true.
    2.3 If we were already traversing a valley(i.e. isValleyActive was true until this step) and if seaLevel 
    has become zero after current step means we have just finishing traversing a valley then set the boolean 
    isValleyActive to false and increment valleyCount by 1.
5. Keep repeating step 4 untill all steps are iterated.
6. Print valleyCount
Time Complexity:  O(n)
Space Complexity: O(1)
*/

    class Counting_Valleys
    {
        // Complete the countingValleys function below.
        static int countingValleys(int n, string s)
        {
            var seaLevel = 0;
            var valleyCount = 0;
            var totalNumberOfSteps = s.Length;
            var garyStepRecord = s.ToArray();
            var isValleyActive = false;

            for (int i = 0; i < totalNumberOfSteps; i++)
            {
                if (garyStepRecord[i] == 'U')
                {
                    seaLevel++;
                }
                else
                {
                    seaLevel--;
                }

                if (!isValleyActive && seaLevel < 0)
                {
                    isValleyActive = true;
                }

                if (isValleyActive && seaLevel == 0)
                {
                    valleyCount++;
                    isValleyActive = false;
                }
            }
            return valleyCount;

        }

        static void Main222fdfds(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int n = Convert.ToInt32(Console.ReadLine());
            //8
            int n = 8;

            //string s = Console.ReadLine();
            //UDDDUDUU
            string s = "UDDDUDUU";

            int result = countingValleys(n, s);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }

    }
}
