using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("请输入第一个数并换行：");
            int.TryParse(Console.ReadLine(), out a);

            char b;
            Console.WriteLine("请输入操作符并换行：");
            char.TryParse(Console.ReadLine(), out b);

            int c;
            Console.WriteLine("请输入第二个数并换行：");
            int.TryParse(Console.ReadLine(), out c);

            switch (b)
            {
                case '+':
                    Console.WriteLine("结果：");
                    Console.WriteLine(a + c);
                    Console.WriteLine("");
                    break;
                case '-':
                    Console.WriteLine("结果：");
                    Console.WriteLine(a - c);
                    Console.WriteLine("");
                    break;
                case '*':
                    Console.WriteLine("结果：");
                    Console.WriteLine(a * c);
                    Console.WriteLine("");
                    break;
                case '/':
                    Console.WriteLine("结果：");
                    Console.WriteLine(a / c);
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
                    //Console.ReadKey();
            }
        }
    }
}
