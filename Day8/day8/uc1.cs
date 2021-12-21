using System;
using System.Collections.Generic;
using System.Text;

namespace day8
{
    class uc1
    {
        public static void Attendance()
        {
             int emp_present = 1;
             Random random = new Random();
             int empcheck = random.Next(0, 2);
             if (empcheck == emp_present)
             {
                Console.WriteLine(" employee is present ");
             }
             else 
             {
                 Console.WriteLine(" employee is absent ");
             }
        }
    }
}