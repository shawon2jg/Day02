using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber10001
{
    class Program
    {
        const int range = 10001;
        static void Main(string[] args)
        {
            int number = 2;
            int prime = 0;
            int primecounter = 0;
            while (primecounter < range)
            {
                bool isprime = true; 
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime)
                {
                    prime = number;
                    primecounter++;
                }
                number++;
            }
            Console.WriteLine("The 10001st prime number is: " + prime);
            Console.ReadLine();
        }
    }
}
