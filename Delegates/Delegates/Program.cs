using Delegates.DelegatesEx;
using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee alex = new Employee();

            alex.EmpName = "Alex Rod";
            alex.Salary = 100000;
            alex.Bonus = 20000;
            alex.CalculateTotalPay();
        }
    }
}
