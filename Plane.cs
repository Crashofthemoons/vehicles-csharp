using System;
using System.Linq;
using System.Collections.Generic;

namespace vehicles
{
    public class Plane : IFly, IDrive
{
  public int Wheels { get; set; }
  public int Doors { get; set; }
  public int PassengerCapacity { get; set; }
  public bool Winged { get; set; }
  public string TransmissionType { get; set; }
  public double EngineVolume { get; set; }
  public double MaxAirSpeed { get; set; }

  public double MaxLandSpeed { get; set; }

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