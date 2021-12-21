using System;
using System.Collections.Generic;
using System.Text;

namespace day8
{
    class uc3
    {
        public static void Parttime()
        {
           int parttime = 1;
           int fulltime = 2;
           int perhour = 20;
           int emphours = 0;
           int wage = 0;
           Random random = new Random();
           int empcheck = random.Next(0, 2);
            if (empcheck == parttime)
            {
                emphours = 4;
            }
            else if (empcheck == fulltime)
            {
                emphours = 8;
            }
            else
            {
                 emphours = 0;
            }
               wage = emphours * perhour;
               Console.WriteLine(" employee wage : " + wage);
        }
    }
}
