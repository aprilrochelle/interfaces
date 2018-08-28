using System;

namespace vehicles
{
  public class Cessna : IAirVehicle
  {
    public bool Winged { get; set; }
    public double MaxAirSpeed { get; set; }
    public int Doors { get; set; }
    public int PassengerCapacity { get; set; }
    public double EngineVolume { get; set; }

    public void Fly()
    {
      Console.WriteLine("Cessna lift off!");
    }

    public void Start()
    {
      Console.WriteLine("Cessna has started.");
    }

    public void Stop()
    {
      Console.WriteLine("Cessna has stopped.");
    }
  }
}
