using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var num1 = num;
            var firstrow = num / 100 + (num / 10) % 10;
            var secondrow = num / 100 + num % 10;
            for (var i = 1; i <= firstrow; i++)
                for (var p = 1; p <= secondrow; p++)
                {
                    if (num1 % 5 == 0) num1 = num1 - num / 100;
                    else if (num1 % 3 == 0) num1 = num1 - (num / 10) % 10;
                    else num1 = num1 + num % 10;
                    Console.Write("{0} ", num1);
                    if (p == secondrow)
                        Console.WriteLine();
                }
            Console.ReadLine();
        }
    }
}
