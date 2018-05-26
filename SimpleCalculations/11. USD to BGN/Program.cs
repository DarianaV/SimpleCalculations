using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double bgn = double.Parse(Console.ReadLine());
            double usd = 1.79549 * bgn;
            Console.WriteLine("{0:F2} BGN", usd);
        }
    }
}
