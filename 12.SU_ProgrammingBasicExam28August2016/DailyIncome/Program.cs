using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            var workdays = double.Parse(Console.ReadLine());
            var salary = double.Parse(Console.ReadLine());
            var dollartolev = double.Parse(Console.ReadLine());
            var monthlysal = workdays * salary;
            var yearincome = monthlysal * 14.5;
            var dds = yearincome * 1 / 4;
            yearincome = (yearincome - dds) * dollartolev;
            var averageincomeperday = yearincome / 365;
            Console.WriteLine(String.Format("{0:0.00}", averageincomeperday));
            Console.ReadLine();
        }
    }
}
