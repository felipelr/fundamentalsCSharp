using System;
using System.Globalization;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var culture = CultureInfo.CreateSpecificCulture("pt-BR");
            decimal valor = 10.25m;

            Console.WriteLine(valor.ToString("G", culture));
            Console.WriteLine(valor.ToString("N", culture));
            Console.WriteLine(valor.ToString("C", culture));
            Console.WriteLine(valor.ToString("P", culture));

            Console.WriteLine(Math.Round(valor));
            Console.WriteLine(Math.Ceiling(valor));
            Console.WriteLine(Math.Floor(valor));
        }
    }
}
