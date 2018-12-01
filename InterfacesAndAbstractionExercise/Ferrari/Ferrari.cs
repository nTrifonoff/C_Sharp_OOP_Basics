using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    public class Ferrari : IBrakes, IGasPedal
    {
        private string driverName;

        public Ferrari(string driverName)
        {
            this.DriverName = driverName;
            this.Model = "488-Spider";
        }

        public string Model { get; set; }

        public string DriverName
        {
            get { return this.driverName; }
            set { this.driverName = value; }
        }

        public void Brakes()
        {
            Console.Write("Brakes!/");
        }

        public void GasPedalPushedDown()
        {
            Console.Write("Zadu6avam sA!/");
        }
    }
}
