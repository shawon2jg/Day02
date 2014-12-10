using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenFibonacciApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0; // First Number
            
            int num2 = 1; // Second Number

            int sum = 0;

            while (num2 <= 1000)
            {
                if (num2 % 2 == 0)
                {
                    sum = sum + num2;
                }

                int tempnum1 = num2;

                if (num2 <= 1)
                {
                    num2++;
                }
                else
                {
                    num2 = num2 + num1;
                }

                num1 = tempnum1;

            }

            Console.WriteLine("The Sum Of The Even-Value is: " + sum);

            Console.ReadKey();
        }
    }
}
