using System;

namespace Garage
{
    public class Cessna : Vehicle, IGas
    {
        public double FuelCapacity { get; set; }
        public int CurrentTank { get; set; }
        public void RefuelTank()
        {
            FuelCapacity = 220;
            CurrentTank = 100;
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