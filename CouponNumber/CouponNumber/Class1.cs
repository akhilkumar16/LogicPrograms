using System;
using System.Collections.Generic;
using System.Text;

namespace CouponNumber
{
	class Class1
	{
		public static void Coupons(int input)
		{
			for (int i = 1; i <= input; i++)
			{
				Random random = new Random();
				int num = random.Next(1000, 999999);
				Console.WriteLine(i + " : " + num);
			}
		}
	}
}

