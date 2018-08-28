using System;
using System.Linq;
using System.Collections.Generic;

namespace vehicles
{
    public class Program
    {

        public static void Main() {

            // Build a collection of all vehicles that fly
            Plane SmallPlane = new Plane();
            Plane Boeing = new Plane();
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

            };
            Drivers Train = new Drivers();
            List<Drivers> Drives = new List<Drivers>();
            Drives.Add(Car);
            Drives.Add(Train);
            // With a single `foreach`, have each road vehicle Drive()
            foreach (Drivers drive in Drives)
            {
                drive.Drive();
            }
            // Build a collection of all vehicles that operate on water

            Floaters Boat = new Floaters();
            Floaters JetSki = new Floaters();
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