using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{

    class program
    {

        class alpha
        {
            class beta : alpha
            {

                static void Main11111()
                {
                    Console.WriteLine ("1");
                    Console.WriteLine ("2");
                    Console.WriteLine ("3");
                    Console.WriteLine ("4");


                }


            }
        }
    }







struct Digit
{
    byte value;

    public Digit(byte value)  //constructor
    {
        if (value > 9)
        {
            throw new System.ArgumentException();
        }
        this.value = value;
    }

    public static explicit operator Digit(byte b)  // explicit byte to digit conversion operator
    {
        Digit d = new Digit(b);  // explicit conversion

        System.Console.WriteLine("Conversion occurred.");
        Console.ReadLine();
        return d;
    }
}

class TestExplicitConversion
{
    static void Main3333()
    {
        try
        {
            byte b = 3;
            Digit d = (Digit)b;  // explicit conversion
        }
        catch (System.Exception e)
        {
            System.Console.WriteLine("{0} Exception caught.", e);

        }
    }
}
}
// Output: Conversion occurred