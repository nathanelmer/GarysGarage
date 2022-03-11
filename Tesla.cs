using System;

namespace Garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} car quietly drove by!");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {Name} quietly rolled to a stop.");
        }
    }
}