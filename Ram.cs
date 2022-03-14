using System;

namespace Garage
{
    public class Ram : Vehicle, IGas
    {
        public double FuelCapacity { get; set; }
        public int CurrentTank { get; set; }
        public void RefuelTank()
        {
            FuelCapacity = 22;
            CurrentTank = 100;
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