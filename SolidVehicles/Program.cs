using SolidVehicles.Contracts;
using SolidVehicles.Vehicles;
using System;
using System.Collections.Generic;

namespace SolidVehicles
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var Air = new List<IAirVehicle>();

            var cessna = new Airplane();
            var zepplin = new Dirigible();

            Air.Add(cessna);
            Air.Add(zepplin);

            foreach (IAirVehicle vehicle in Air)
            {
                vehicle.Fly();
            }

            var Land = new List<ILandVehicle>();

            var bmw = new Motorcycle();
            var valiant = new Car();

            Land.Add(bmw);
            Land.Add(valiant);

            foreach (ILandVehicle vehicle in Land)
            {
                vehicle.Drive();
            }

            var Sea = new List<IWaterVehicle>();

            var yamaha = new JetSki();
            var house = new Houseboat();

            Sea.Add(yamaha);
            Sea.Add(house);

            foreach (IWaterVehicle floater in Sea)
            {
                floater.Drive();
            }
        }
    }
}
