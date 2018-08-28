namespace vehicles
{
  public interface ILandVehicle : IVehicle
  {
    int Wheels { get; set; }
    string TransmissionType { get; set; }
    double MaxLandSpeed { get; set; }
    void Drive();
  }
}
