using System;

namespace vehicles
{
  public class JetSki : IWaterVehicle
  {
    public double MaxWaterSpeed { get; set; }
    public int Doors { get; set; }
    public int PassengerCapacity { get; set; }
    public double EngineVolume { get; set; }

    public void Start()
    {
      Console.WriteLine("The jetski has started!");
    }

    public void Stop()
    {
      Console.WriteLine("The jetski has stopped.");
    }

    public void Drive()
    {
      Console.WriteLine("Jetski GOOOO!");
    }
  }
}