using System;

namespace Garage
{
    public class Cessna : Vehicle  // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }
        public void RefuelTank()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} plane zoomed by!");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {Name} came to a stop on the runway.");
        }
    }
}