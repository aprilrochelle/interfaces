using System;

namespace vehicles
{
  public class Motorcycle : ILandVehicle
  {
    public int Wheels { get; set; }
    public string TransmissionType { get; set; }
    public double MaxLandSpeed { get; set; }
    public int Doors { get; set; }
    public int PassengerCapacity { get; set;}
    public double EngineVolume { get; set; }

    public void Drive()
    {
      Console.WriteLine("Motorcycle go VROOM!");
    }

    public void Start()
    {
      Console.WriteLine("Motorcyle has started.");
    }

    public void Stop()
    {
      Console.WriteLine("Motorcycle has stopped.");
    }
  }
}
