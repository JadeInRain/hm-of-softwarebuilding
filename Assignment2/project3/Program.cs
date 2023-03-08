using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int max = 101;
            int[] number = new int[max];
            for (int i = 2; i <= max / 2; i++)//i为除数，从2递增至50
            {
                for (int j = 2; j <= max; j++)
                {
                    if (j % i == 0 && j / i > 1) number[j] = 1;
                }
            }
            for (int i = 2; i < max; i++)
            {
                if (number[i] == 0) System.Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
