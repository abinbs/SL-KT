using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates.DelegatesEx
{
    public class Employee
    {
        public string EmpName { get; set; }
        public decimal Salary { get; set; }
        public decimal Bonus { get; set; }
        public decimal TotalPay { get; set; }

        public void CalculateTotalPay()
        {
            TotalPay = Salary + Bonus;
            Console.WriteLine("Total Pay = " + TotalPay);
        }


    }
}
