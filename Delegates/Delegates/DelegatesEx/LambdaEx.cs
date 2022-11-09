using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates.DelegatesEx
{
    //public delegate int Calculate(int x, int y);
    //public delegate int Operate(int x);
    //public delegate string GetName(Employee obj);
    //public delegate string NoPrams();
    //public delegate void PrintSomething(string x);

    public class LambdaEx
    {
        public static void Main()
        {
           // Operate op = (x) => x * 2;
           //Func last parameter is return type
            Func<int,int> op = (x) => x * 2;

            Console.WriteLine(op(4));

            //Calculate calc = (x, y) => x * y;
            Func<int, int, int> calc = (x, y) => x * y;
            Console.WriteLine(calc(4,5));

            //GetName name = (x) => x.EmpName;
            Func<Employee, string> name = (x) => x.EmpName;

            Employee alex = new Employee { EmpName = "Alex Rod", Salary = 10000 };

            Console.WriteLine(name(alex));

            //NoPrams prams = () => "Hello World";
            Func<string> prams = () => "Hello World";
            Console.WriteLine(prams());

            calc = (x, y) =>
            {
                Console.WriteLine("Multiline");
                return x + y;

            };

            Console.WriteLine(calc(10,20));
            //Action has no return type
            Action<string> act = (x) => { Console.WriteLine("Hello " + x); };
            act("Alex");

            Predicate<int> p = (x) => x > 0;
            Console.WriteLine(p(-2));
        }
    }
}
