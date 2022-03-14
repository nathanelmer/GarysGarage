using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectric
    {
        public double BatteryKWh { get; set; }
        public int CurrentCharge { get; set; }
        public void ChargeBattery()
        {
            BatteryKWh = 175;
            CurrentCharge = 100;
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