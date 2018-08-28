using System;
using System.Linq;
using System.Collections.Generic;

namespace vehicles
{
    public class Plane : IFly, IDrive
{
  public int Wheels { get; set; } = 3;
  public int Doors { get; set; } = 3;
  public int PassengerCapacity { get; set; } = 113;
  public bool Winged { get; set; } = true;
  public string TransmissionType { get; set; } = "None";
  public double EngineVolume { get; set; } = 31.1;
  public double MaxAirSpeed { get; set; } = 309.0;

  public double MaxLandSpeed { get; set; } = 100;

  public void Drive()
  {
    Console.WriteLine("I need to drive to fly.");
  }

  public void Fly()
  {
    Console.WriteLine("The Cessna effortlessly glides through the clouds like a gleaming god of the Sun");
  }

  public void Start()
  {
    throw new NotImplementedException();
  }

  public void Stop()
  {
    throw new NotImplementedException();
  }
}


}