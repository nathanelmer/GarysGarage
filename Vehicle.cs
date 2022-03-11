using System;

namespace Garage
{
    public class Vehicle
    {
        public string Name { get; set; }
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        public virtual void Drive()
        {
            Console.WriteLine("Vroooom!");
        }
        public void Turn()
        {
            Console.WriteLine($"The {MainColor} {Name} turns right.");
        }
        public virtual void Stop()
        {
            Console.WriteLine("The vehicle stopped.");
        }
    }
}