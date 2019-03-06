using System;
//student name yogesh yogesh
// student id c0722784
//csd3354 Section 2
//Assignment 2
// march 6,2019
namespace DelegatesAndEvents
{
    using System;

    delegate void ExampleDelegate(string xyz);

    class Program
    {
        public static void Method1(string xyz)
        {
            Console.WriteLine(xyz + " Method1");
        }

        public static void Method2(string xyz)
        {
            Console.WriteLine(xyz + " Method2");
        }

        public static void Main()
        {
            ExampleDelegate ex1Delegate, ex2Delegate, ex3Delegate, myDelegate;

            ex1Delegate = new ExampleDelegate(Method1);
            ex2Delegate = new ExampleDelegate(Method2);
            ex3Delegate = ex1Delegate + ex2Delegate;
            myDelegate = ex1Delegate - ex2Delegate;
            ex1Delegate("AAA");
            ex2Delegate("BBB");
            ex3Delegate("CCC");
            myDelegate("DDD");
            myDelegate = ex3Delegate - ex1Delegate;
            myDelegate("EEE");
            myDelegate = ex3Delegate - ex2Delegate;
            myDelegate("FFF");
            Console.ReadLine();
        }
    }
}