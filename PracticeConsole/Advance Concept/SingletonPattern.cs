using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    public sealed class SingletonPattern
    {
        SingletonPattern()
        {
            Console.WriteLine("Private Constructor");
        }
        static SingletonPattern()
        {
            Console.WriteLine("static Constructor");
        }
        private static readonly object padlock = new object();
        private static SingletonPattern instance = null;
        public static SingletonPattern GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonPattern();
                        }
                    }
                }
                return instance;
            }
        }
    }

    public class NormalClass
    {
        public NormalClass()
        {
            Console.WriteLine("public Constructor");
        }
        static NormalClass()
        {
            Console.WriteLine("static Constructor");
        }
    }

    class owais
    {
        static void Main ()
        {

            //SingletonPattern obj = new SingletonPattern();
            //SingletonPattern abc = SingletonPattern.GetInstance;
            //SingletonPattern abc2 = SingletonPattern.GetInstance;
            //SingletonPattern abc3 = SingletonPattern.GetInstance;
            //SingletonPattern abc4 = SingletonPattern.GetInstance;
            //SingletonPattern abc5 = SingletonPattern.GetInstance;
            NormalClass a1 = new NormalClass();
            NormalClass a2 = new NormalClass();
            NormalClass a3 = new NormalClass();
        }
    }
 
}
