using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace population
{
    class Program
    {
        static void Main(string[] args)
        {
            Arge.NbYear(1500, 5, 100, 5000);
            Arge.NbYear(1500000, 2.5, 10000, 2000000);
            Arge.NbYear(1500000, 0.25, 1000, 2000000);
        }
    }
    class Arge
    {
        public static int NbYear(int p0, double percent, int aug, int p)
        {
            int years = 0;
            while (p0 < p)
            {
                p0 += (int)((p0 * (percent / 100)) + aug);
                years++;
            }

            return years;
        }
    }
}
