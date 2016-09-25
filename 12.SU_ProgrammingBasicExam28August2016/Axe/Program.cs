using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var leftBr = 0;
            var m = 0;
            var k = 0;
            Console.Write(new string('-', 3 * n));
            Console.Write("**");
            Console.WriteLine(new string('-', 2 * n - 2));
            for (var i = 1; i <= n - 1; i++)
            {
                Console.Write(new string('-', 3 * n));
                Console.Write("*");
                Console.Write(new string('-', i));
                Console.Write("*");
                Console.WriteLine(new string('-', 2 * n - i - 2));
            }
            for (var i1 = 1; i1 <= n / 2; i1++)
            {
                Console.Write(new string('*', 3 * n));
                Console.Write("*");
                Console.Write(new string('-', n - 1));
                Console.Write("*");
                Console.WriteLine(new string('-', n - 1));
            }
            for (var i2 = 0; i2 < n / 2 - 1; i2++)
            {
                Console.Write(new string('-', 3 * n - i2));
                Console.Write("*");
                Console.Write(new string('-', n - 1 + m));
                Console.Write("*");
                Console.WriteLine(new string('-', n -1 - k));
                leftBr++;
                m = m + 2;
                k++;
            }
            if (n % 2 == 0)
            {
                Console.Write(new string('-', 3 * n - leftBr));
                Console.Write(new string('*', 2 * n - n / 2 + leftBr));
                Console.WriteLine(new string('-', n / 2));
            }
            else
            {
                Console.Write(new string('-', 3 * n - leftBr));
                Console.Write(new string('*', 2 * n - n / 2 + leftBr - 1));
                Console.WriteLine(new string('-', n / 2 + 1));
            }
            Console.ReadLine();
        }
    }
}
