using System;

namespace CouponNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many Distinct Coupon Codes Do you Want Generate?");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(input + " Distinct Coupon Codes are: ");

            Class1.Coupons(input);
        }
    }
}