using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string value1 = Console.ReadLine();
            string value2 = Console.ReadLine();
            if (value1 == "BGN" && value2 == "EUR")
            {
                double eur = n / 1.95583;
                Console.WriteLine("{0:F2} EUR", eur);
            }
            if (value1 == "USD" && value2 == "BGN")
            {
                double usd = 1.79549 * n;
                Console.WriteLine("{0:F2} BGN", usd);
            }
            if (value1 == "GBP" && value2 == "USD")
            {
                double gbp = n * 2.53405;
                double usd = 1.79549;
                double sum = gbp / usd;
                Console.WriteLine("{0:F2} USD", sum);
            }
            if (value1 == "EUR" && value2 == "GBP")
            {
                double gbp = 2.53405;
                double eur = n * 1.95583;
                double sum = eur / gbp;
                Console.WriteLine("{0:F2} GBP", sum);
            }
            else if (value1 == "USD" && value2 == "EUR")
            {
                double usd = n * 1.79549;
                double eur = 1.95583;
                double result = usd / eur;
                Console.WriteLine("{0:F2} EUR", result);
            }
        }
    }
}
