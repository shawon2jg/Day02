using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfPrimeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            long iLimit = 2000000;

            long iStart = 1;

           
            long SumOfPrime = 1;

            while (iStart < iLimit)
            {
                if (IsPrime(iStart))
                {
                    SumOfPrime += iStart;
                }

                iStart += 2;
            }

            Console.WriteLine(SumOfPrime);

            Console.ReadKey();
        }

        static bool IsPrime(long val)
        {
            if (val == 2 || val == 3 || val == 5 || val == 7)
                return true;

            for (long i = 2; i <= Math.Sqrt(val); i++)
            {
                if (val % i == 0)
                    return false;
            }

            return true; 
        }
    }
}
