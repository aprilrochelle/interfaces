namespace vehicles
{
  public interface IAirVehicle : IVehicle
  {
    bool Winged { get; set; }
    double MaxAirSpeed { get; set; }
    void Fly();
  }
}