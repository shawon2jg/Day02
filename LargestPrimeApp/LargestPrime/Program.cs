using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            const long constantInput = 600851475143;
            long input = constantInput;
            long divider = 2;
            long multiplyList = 1;
            bool largestPrimeFound = false;
            while (largestPrimeFound == false)
            {
                if (input % divider == 0)
                {
                    long val = input / divider;
                    input = val;
                    Console.WriteLine(divider);
                    multiplyList *= divider;
                    if (multiplyList == constantInput)
                    {
                        Console.WriteLine("The largest prime factor of " + constantInput + " is : " + divider);
                        largestPrimeFound = true;
                    }
                }
                else
                {
                    divider += 1;
                }
            }
            Console.ReadLine();
        }
    }
}
