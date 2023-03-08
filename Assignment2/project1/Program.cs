using System;
using System.Collections.Generic;

namespace hm2_1
{
    public class FactorApp
    {
        public static void Main(string[] args)
        {
                Console.Write("输入一个整数:");
                int num = Convert.ToInt32(Console.ReadLine());
                List<int> factors = Factorize(num);
                Console.Write("它的素因子有:");
                factors.ForEach(f => Console.Write( f));
            Console.ReadKey();
        }
        private static List<int> Factorize(int num)
        {
            if (num <= 1)
            {
                throw new ArgumentException("num必须大于1");
            }

            List<int> factors = new List<int>();
            int n = num;
            for (int i = 2; i * i <= n; i++)
            {
                while (n % i == 0)
                {
                    factors.Add(i);
                    n = n / i; 
                }
            }
            if (n != 1)
            {
                factors.Add(n);
            }
            return factors;
        }
    }
}

