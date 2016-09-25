using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = double.Parse(Console.ReadLine());
            var days = double.Parse(Console.ReadLine());
            var workers = double.Parse(Console.ReadLine());
            var workhours = (days - days * 1 / 10) * 8;
            var immedieatwork = workers * days * 2;
            var totaltime = Math.Floor(workhours + immedieatwork);
            if (totaltime >= hours)
                Console.WriteLine("Yes!{0} hours left.", totaltime - hours);
            else
                Console.WriteLine("Not enough time!{0} hours needed.", hours - totaltime);
            Console.ReadLine();
        }
    }
}
