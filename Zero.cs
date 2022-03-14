using System;

namespace Garage
{
    public class Zero : Vehicle, IElectric// Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public int CurrentCharge { get; set; }
        public void ChargeBattery()
        {
            BatteryKWh = 150;
            CurrentCharge = 100;
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