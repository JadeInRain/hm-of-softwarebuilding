using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] balance = { 123,423,53,314,12,5,134,1,734,6 };
            int max=0, min=100000, ave, sum=0;
            for (int i = 0; i < 10; i++)
            {
                if (max < balance[i]) max = balance[i];
                if (min > balance[i]) min = balance[i];
                sum = sum + balance[i];

            }
            ave = sum / 5;
            Console.WriteLine("最大值为"+max);
            Console.WriteLine("最小值为" + min);
            Console.WriteLine("平均值为" + ave);
            Console.WriteLine("总和为" + sum);
            Console.ReadKey();
        }
        
    }
}
