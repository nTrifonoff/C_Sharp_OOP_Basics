using System;
using System.Linq;

namespace DateModifier
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();

            double output = DateModifier.GetDaysBetweenDates(date1, date2);

            Console.WriteLine(output);
        }
    }
}
