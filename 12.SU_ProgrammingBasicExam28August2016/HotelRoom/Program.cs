using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var holidaynum = double.Parse(Console.ReadLine());
            if (month == "May" || month == "October")
            {
                if (holidaynum > 7 && holidaynum <= 14)
                {
                    var studio1 = holidaynum * (50.0 - 50.0 / 20);
                    var apartment1 = holidaynum * 65.0;
                    Console.WriteLine("Apartment: {0} lv.", String.Format("{0:0.00}", apartment1));
                    Console.WriteLine("Studio: {0} lv.", String.Format("{0:0.00}", studio1));
                }
                else if (holidaynum > 14)
                {
                    var studio2 = holidaynum * (50.0 - 50.0 * 3 / 10);
                    var apartment2 = holidaynum * (65.0 - 65.0 / 10);
                    Console.WriteLine("Apartment: {0} lv.", String.Format("{0:0.00}", apartment2));
                    Console.WriteLine("Studio: {0} lv.", String.Format("{0:0.00}", studio2));
                }
                else
                {
                    var studio5 = holidaynum * 50.0;
                    var apartment5 = holidaynum * 65.0;
                    Console.WriteLine("Apartment: {0} lv.", String.Format("{0:0.00}", apartment5));
                    Console.WriteLine("Studio: {0} lv.", String.Format("{0:0.00}", studio5));
                }
            }
            if (month == "June" || month == "September")
            {
                if (holidaynum <= 14)
                {
                    var studio3 = holidaynum * 75.2;
                    var apartment3 = holidaynum * 68.7;
                    Console.WriteLine("Apartment: {0} lv.", String.Format("{0:0.00}", apartment3));
                    Console.WriteLine("Studio: {0} lv.", String.Format("{0:0.00}", studio3));
                }
                else if (holidaynum > 14)
                {
                    var studio4 = holidaynum * (75.2 - 75.2 * 1 / 5);
                    var apartment4 = holidaynum * (68.7 - 68.7 / 10);
                    Console.WriteLine("Apartment: {0} lv.", String.Format("{0:0.00}", apartment4));
                    Console.WriteLine("Studio: {0} lv.", String.Format("{0:0.00}", studio4));
                }
            }
            if (month == "July" || month == "August")
            {
                if (holidaynum > 14)
                {
                    var studio6 = holidaynum * 76.0;
                    var apartment6 = holidaynum * (77.0 - 77.0 / 10);
                    Console.WriteLine("Apartment: {0} lv.", String.Format("{0:0.00}", apartment6));
                    Console.WriteLine("Studio: {0} lv.", String.Format("{0:0.00}", studio6));
                }
                else
                {
                    var studio7 = holidaynum * 76.0;
                    var apartment7 = holidaynum * 77.0;
                    Console.WriteLine("Apartment: {0} lv.", String.Format("{0:0.00}", apartment7));
                    Console.WriteLine("Studio: {0} lv.", String.Format("{0:0.00}", studio7));
                }
            }
            Console.ReadLine();
        }
    }
}
