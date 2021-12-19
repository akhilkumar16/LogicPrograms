using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            while (i <= num - 1)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("Entered  Number is not Prime");
                    break;
                }
                i++;
            }
            if (num == i)
            {
                Console.WriteLine("Entered Number is an Prime Number");
            }

        }
    }
}