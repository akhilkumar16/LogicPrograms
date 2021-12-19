using System;

namespace PerfectNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;
            int n;
            Console.Write("Enter A Number : ");
            num =Convert.ToInt32(Console.ReadLine());
            n = num;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("\n Entered number is a perfect number");
            }
            else
            {
                Console.WriteLine("\n Entered number is not a perfect number");
            }
        }
    }
}