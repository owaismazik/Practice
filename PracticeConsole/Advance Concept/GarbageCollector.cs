﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.Flow_Control
{
    class GarbageCollector
    {

        private const int maxGarbage = 100000;

        static void Main222 ()
        {
            // Put some objects in memory.
            GarbageCollector.MakeSomeGarbage ();
            Console.WriteLine ("Memory used before collection:       {0:N0}",
                              GC.GetTotalMemory (false));

            // Collect all generations of memory.
            //inGC.Collect ();
            Console.WriteLine ("Memory used after full collection:   {0:N0}",
                              GC.GetTotalMemory (true));
            Console.ReadLine ();
        }

        static void MakeSomeGarbage ()
        {
            Version vt;

            // Create objects and release them to fill up memory with unused objects.
            for (int i = 0; i < maxGarbage; i++)
            {
                vt = new Version ();
            }
        }

        public static void Main()
        {
            Console.WriteLine("Hello World");
            Console.WriteLine(fact(5));
            Console.WriteLine(fact2(5));
            //fact(5);
        }

        public static int fact(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * fact(n - 1);
            }
        }

        public static int fact2(int n)
        {
            int fa = 1;
            for (int i = 1; i <= n; i++)
            {

                fa = fa * i;
                Console.WriteLine(fa);
            }
            return fa;
        }
    }
}