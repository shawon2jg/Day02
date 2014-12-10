using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 100;
            int max = 999;
            List<int> list = new List<int>();
            int multiplied = 0;
            for (int i = min; i < max; i++)
            {
                for (int j = min; j < max; j++)
                {
                    multiplied = i * j;
                    string reversed = new string(multiplied.ToString().ToCharArray().Reverse().ToArray());
                    if (reversed == multiplied.ToString())
                    {
                        list.Add(multiplied);
                    }
                }
            }
            Console.WriteLine("The largest palindrome of two 3-digit numbers is : " + list.Max());
            Console.ReadLine();
        }
    }
}
