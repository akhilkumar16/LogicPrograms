﻿using System;
using System.Collections.Generic;
using System.Text;

namespace day8
{
    class uc4
    {
        public const int parttime = 1;
        public const int fulltime = 2;
        public const int perhour = 20;
        public static void SwitchCase()
        {
            int emphours = 0;
            int wage = 0;
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            switch (empcheck)
            {
                case parttime:
                    emphours = 4;
                    break;
                case fulltime:
                    emphours = 8;
                    break;
                default:
                    emphours = 0;
                    break;
            }
              wage = emphours* perhour;
              Console.WriteLine(" employee wages : " + wage);
        }
    }
}