using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace SalaryStatsApp
{
    class Program
    {
        static void Main()
        {
            List<int> salaries = new()
            {
                2700, 3000, 3200, 3200, 3200, 3600, 3700, 4000, 4500, 20000,
                3100, 3300, 3400, 3500, 3600, 3700, 3800, 3900, 4000, 4100,
                4200, 4300, 4400, 4500, 4600, 4700, 4800, 4900, 5000, 5100
            };

            double average = salaries.Average();
            var sorted = salaries.OrderBy(s => s).ToList();
            double median = 0;
            int counter = sorted.Count();
            if (counter % 2 == 0)
            {
                median = (sorted[14] + sorted[15]) / 2.0;
            }
            else
            {
                counter = counter / 2;
                median = counter;
            }

            int mode = salaries.GroupBy(s => s).OrderByDescending(g => g.Count()).First().Key;

            Console.WriteLine($"Średnia: {average:F2} PLN");
            Console.WriteLine($"Mediana: {median:F2} PLN");
            Console.WriteLine($"Moda: {mode} PLN");
        }
    }
}
