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
            int.TryParse(Console.ReadLine(), out a);

            char b;
            char.TryParse(Console.ReadLine(), out b);

            int c;
            int.TryParse(Console.ReadLine(), out c);

            switch (b)
            {
                case '+':
                    Console.WriteLine("=");
                    Console.WriteLine(a + c);
                    Console.WriteLine("");
                    break;
                case '-':
                    Console.WriteLine("=");
                    Console.WriteLine(a - c);
                    Console.WriteLine("");
                    break;
                case '*':
                    Console.WriteLine("=");
                    Console.WriteLine(a * c);
                    Console.WriteLine("");
                    break;
                case '/':
                    Console.WriteLine("=");
                    Console.WriteLine(a / c);
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Invalid Expression");
                    break;
                    Console.ReadKey();
            }
        }
    }
}