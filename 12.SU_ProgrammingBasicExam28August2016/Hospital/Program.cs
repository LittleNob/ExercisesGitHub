using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var period = int.Parse(Console.ReadLine());
            var doctors = 7;
            var treated = 0;
            var untreated = 0;
            for (var i = 1; i <= period; i++)
            {
                var patients = int.Parse(Console.ReadLine());
                if (i % 3 == 0)
                {
                    if (treated < untreated)
                        doctors++;
                }
                if (doctors - patients >= 0)
                {
                    treated = treated + patients;
                }
                else
                {
                    treated = treated + doctors;
                    untreated = untreated + patients - doctors;
                }
                
            }
            Console.WriteLine("Treated patients: {0}.", treated);
            Console.WriteLine("Untreated patients: {0}.", untreated);
            Console.ReadLine();
        }
    }
}
