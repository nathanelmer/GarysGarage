using System;

namespace Garage
{
    public class Zero : Vehicle  // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} car vroomed by!");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {Name} came to a stop like it never moved.");
        }
    }
}