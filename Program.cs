using System;
using System.Linq;
using System.Collections.Generic;

namespace vehicles
{
    public class Program
    {

        public static void Main() {

            // Build a collection of all vehicles that fly
            Plane SmallPlane = new Plane()
            {
                Wheels= 3,
                Doors = 3,
                PassengerCapacity = 113,
                Winged = true,
                TransmissionType = "None",
                EngineVolume = 31.1,
                MaxAirSpeed = 309.0,
                MaxLandSpeed = 100
            };
            Plane Boeing = new Plane()
            {
                Wheels= 3,
                Doors = 3,
                PassengerCapacity = 113,
                Winged = true,
                TransmissionType = "None",
                EngineVolume = 31.1,
                MaxAirSpeed = 309.0,
                MaxLandSpeed = 100
            };
            List<Plane> Planes = new List<Plane>();
            Planes.Add(SmallPlane);
            Planes.Add(Boeing);
            // With a single `foreach`, have each vehicle Fly()
            foreach (Plane plane in Planes)
            {
                plane.Fly();
            }

            // Build a collection of all vehicles that operate on roads
            Drivers Car = new Drivers()
            {
                Wheels = 4,
                Doors = 4,
                PassengerCapacity = 8,
                TransmissionType = "Automatic",
                EngineVolume = 2.0,
                MaxLandSpeed = 100
            };
            Drivers Train = new Drivers()
            {
                Wheels = 90,
                Doors = 10,
                PassengerCapacity = 5000,
                TransmissionType = "Manual",
                EngineVolume = 2.0,
                MaxLandSpeed = 200
            };
            List<Drivers> Drives = new List<Drivers>();
            Drives.Add(Car);
            Drives.Add(Train);
            // With a single `foreach`, have each road vehicle Drive()
            foreach (Drivers drive in Drives)
            {
                drive.Drive();
            }
            // Build a collection of all vehicles that operate on water

            Floaters Boat = new Floaters()
            {
                Doors = 0,
                PassengerCapacity = 6,
                TransmissionType = "Water",
                EngineVolume = 5,
                MaxWaterSpeed = 40
            };
            Floaters JetSki = new Floaters()
            {
                Doors = 0,
                PassengerCapacity = 6,
                TransmissionType = "Water",
                EngineVolume = 5,
                MaxWaterSpeed = 40
            };
            List<Floaters> Floats = new List<Floaters>();
            Floats.Add(Boat);
            Floats.Add(JetSki);
            // With a single `foreach`, have each water vehicle Drive()
            foreach (Floaters floats in Floats)
            {
                floats.Float();
            }
        }

    }

}