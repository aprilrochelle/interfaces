using System;

namespace vehicles
{
  public class Helicopter : IAirVehicle
  {
    public bool Winged { get; set; }
    public double MaxAirSpeed { get; set; }
    public int Doors { get; set; }
    public int PassengerCapacity { get; set; }
    public double EngineVolume { get; set; }

    public void Fly()
    {
      Console.WriteLine("Helicopter lift off!");
    }

    public void Start()
    {
      Console.WriteLine("Helicopter has started.");
    }

    public void Stop()
    {
      Console.WriteLine("Helicopter has stopped.");
    }
  }
}