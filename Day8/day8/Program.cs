using System;

namespace day8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            uc1.Attendance();

            uc2 obj = new uc2();
            obj.Wages();

            uc3.Parttime();

            uc4.SwitchCase();

            uc5 obj1 = new uc5();
            obj1.Monthly();

            uc6.WorkingHours();

            uc7.computeEmpWage();
        }
    }
}
