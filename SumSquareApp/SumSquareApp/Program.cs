using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSquareApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((SumOfN(100) * SumOfN(100)) - SumOfSquareOf(100));

            Console.ReadKey();
        }

        static long SumOfSquareOf(int n)
        {

            return (n*(n + 1)*((2*n) + 1))/6;

        }

        static long SumOfN(int n)
        {
            return (n * (n + 1) )/ 2;
            
        }
    }
}
