namespace vehicles
{
  public interface IWaterVehicle : IVehicle
  {
    double MaxWaterSpeed { get; set; }
    void Drive();
  }
}