using System;

public interface IGas
{
    double FuelCapacity { get; set; }
    void RefuelTank();
    int CurrentTank { get; set; }
}

public interface IElectric
{
    double BatteryKWh { get; set; }
    void ChargeBattery();
    int CurrentCharge { get; set; }
}