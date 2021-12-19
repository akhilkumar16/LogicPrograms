using System;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int reverse = 0;
            Console.WriteLine("Enter a Number : ");
            num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                reverse = reverse * 10;
                reverse = reverse + num % 10;
                num = num / 10;
            }
            Console.WriteLine("Reverse of Number is : " + reverse);
            Console.ReadLine();

        }
    }
}
