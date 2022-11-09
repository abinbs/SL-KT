using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates.DelegatesEx
{
    // A delegate is a pointer to a method.
    //A delegate can point to any method that has the same signature and return type.
    public delegate int Calculate(int a, int b);
    public class DelegateClass
    {
        //public static int Add(int x, int y)
        //{
        //    Console.WriteLine("Inside Add ");
        //    return x + y;
        //}

        //public static int Subtract(int x, int y)
        //{
        //    Console.WriteLine("Inside Subtract ");
        //    return x - y;
        //}

        //public int Divide(int x, int y)
        //{
        //    Console.WriteLine("Inside Divide ");
        //    return x / y;
        //}

        public decimal MethodA(int a, int b, Calculate z)
        {
            return z(a, b);
        }

    }


    class TestDelegate
    {
        static void Main()
        {
            int x = 10;
            //Calculate calc = DelegateClass.Add;
            //Console.WriteLine(calc(10,20));
            //x = 20;
            //calc = DelegateClass.Subtract;
            //Console.WriteLine(calc(10, 20));



            //DelegateClass obj = new DelegateClass();
            //calc = obj.Divide;
            //Console.WriteLine(calc(20, 5));

            //calc = DelegateClass.Subtract;
            //Console.WriteLine( obj.MethodA(200, 5, calc));

            x = 30;

            Calculate calc = delegate (int a, int b)
            {
                Console.WriteLine("Anonymous method");
                return a + b + 5;
            };

            Console.WriteLine(calc(20, 5));
            //Console.WriteLine(obj.MethodA(200, 5, calc));
        }
    }
}
