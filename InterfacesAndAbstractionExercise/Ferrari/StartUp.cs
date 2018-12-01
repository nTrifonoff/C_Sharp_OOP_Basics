using System;

namespace Ferrari
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string driverName = Console.ReadLine();

            Ferrari ferrari = new Ferrari(driverName);

            Console.Write(ferrari.Model + "/");
            ferrari.Brakes();
            ferrari.GasPedalPushedDown();
            Console.Write(ferrari.DriverName);
            Console.WriteLine();
        }
    }
}
