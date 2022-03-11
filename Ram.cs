using System;

namespace Garage
{
    public class Ram : Vehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public void RefuelTank()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} truck rumbled by!");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {Name} rolled to a stop.");
        }
    }
}