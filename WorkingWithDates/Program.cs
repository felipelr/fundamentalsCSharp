using System;
using System.Globalization;

namespace WorkingWithDates
{
    class Program
    {
        static void Main(string[] args)
        {
            var br = new CultureInfo("pt-BR");
            var data = DateTime.UtcNow; //pega data atual sem nenhum timezone
            Console.WriteLine(data.ToString("D"));
            Console.WriteLine(data.ToString("D", br));

            Console.WriteLine(DateTime.DaysInMonth(2021, 2));
            Console.WriteLine($"Hoje é final de semana {IsWeekend(data.DayOfWeek)}");
            Console.WriteLine($"Hoje estamos no horário de verão {data.IsDaylightSavingTime()}");

            var timeZoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Cen. Australia Standard Time");
            Console.WriteLine(timeZoneAustralia);
            var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(data, timeZoneAustralia);

            /* var timeZones = TimeZoneInfo.GetSystemTimeZones();
            foreach (var timezone in timeZones)
            {
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(data, timezone));
                Console.WriteLine("-------------");
            } */
        }

        static bool IsWeekend(DayOfWeek today)
        {
            return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
        }
    }
}
