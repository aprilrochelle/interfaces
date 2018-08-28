using System.Linq;
using System.Collections.Generic;

namespace vehicles
{
  public class Program
  {

    public static void Main()
    {

      // Build a collection of all vehicles that fly
      List<IAirVehicle> aircraft = new List<IAirVehicle>();

      Cessna c172 = new Cessna() {
        Winged = true,
        MaxAirSpeed = 239,
        Doors = 1,
        PassengerCapacity = 4,
        EngineVolume = 29,
      };

      Helicopter lifeFlight = new Helicopter() {
        Winged = false,
        MaxAirSpeed = 200,
        Doors = 2,
        PassengerCapacity = 3,
        EngineVolume = 29,
      };

      aircraft.Add(lifeFlight);
      aircraft.Add(c172);

      // With a single `foreach`, have each vehicle Fly()
      foreach (IAirVehicle a in aircraft)
      {
          a.Fly();
      }


      // Build a collection of all vehicles that operate on roads
      List<ILandVehicle> landRovers = new List<ILandVehicle>();

      Motorcycle Bmw = new Motorcycle() {
        MaxLandSpeed = 219,
        Doors = 0,
        PassengerCapacity = 2,
        TransmissionType = "Manual",
        EngineVolume = 20,
        Wheels = 2,
      };

      Motorcycle Harley = new Motorcycle() {
        MaxLandSpeed = 180,
        Doors = 0,
        PassengerCapacity = 2,
        TransmissionType = "Manual",
        EngineVolume = 25,
        Wheels = 2,
      };

      landRovers.Add(Harley);
      landRovers.Add(Bmw);

      // With a single `foreach`, have each road vehicle Drive()
      foreach (ILandVehicle l in landRovers)
      {
          l.Drive();
      }


      // Build a collection of all vehicles that operate on water
      List<IWaterVehicle> waterCrafts = new List<IWaterVehicle>();
      JetSki Kawasaki = new JetSki() {
        MaxWaterSpeed = 45.00,
        Doors = 0,
        PassengerCapacity = 1,
        EngineVolume = 10.00,
      };

      Submarine u584 = new Submarine() {
        MaxWaterSpeed = 150.00,
        Doors = 2,
        PassengerCapacity = 6,
        EngineVolume = 2.00,
      };

      waterCrafts.Add(Kawasaki);
      waterCrafts.Add(u584);

      // With a single `foreach`, have each water vehicle Drive()
      foreach (IWaterVehicle w in waterCrafts)
      {
          w.Drive();
      }
    }

  }
}
