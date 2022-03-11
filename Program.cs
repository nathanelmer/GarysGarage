using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero
            {
                Name = "Fxs",
                MainColor = "Green"
            };
            Tesla modelS = new Tesla
            {
                Name = "Tesla",
                MainColor = "White"
            };
            Cessna mx410 = new Cessna
            {
                Name = "Mx410",
                MainColor = "Blue"
            };

            fxs.Drive();
            fxs.Turn();
            fxs.Stop();
            modelS.Drive();
            modelS.Turn();
            modelS.Stop();
            mx410.Drive();
            mx410.Turn();
            mx410.Stop();
        }
    }
}