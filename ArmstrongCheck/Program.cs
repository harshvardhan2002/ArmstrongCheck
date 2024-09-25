using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, digitsCount=0;
            Console.WriteLine("Enter the value to check whether it is Armstrong number or not: ");
            int number= Convert.ToInt32(Console.ReadLine());

            int tempNumber1 = number;
            while (tempNumber1 > 0)
            {
                tempNumber1 = tempNumber1 / 10;
                digitsCount++;
            }

            int tempNumber2 = number;
            while (tempNumber2 > 0)
            {
                int ones = tempNumber2 % 10;
                int power = 1;
                for (int i = 0; i < digitsCount; i++)
                {
                    power = power * ones;
                }
                sum = sum + power;
                tempNumber2 = tempNumber2 / 10;
            }
            if (sum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
