using System;

namespace vehicles
{
  public class Submarine : IWaterVehicle
  {
    public double MaxWaterSpeed { get; set; }
    public int Doors { get; set; }
    public int PassengerCapacity { get; set; }
    public double EngineVolume { get; set; }

    public void Start()
    {
      Console.WriteLine("The submarine has started!");
    }

    public void Stop()
    {
      Console.WriteLine("The submarine has stopped.");
    }

    public void Drive()
    {
      Console.WriteLine("Submarine GOOOO!");
    }
  }
}