﻿using SolidVehicles.Contracts;
using System;

namespace SolidVehicles.Vehicles
{
    public class Motorcycle : IVehicle, ILandVehicle
    {
        public string Name { get; set; }
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int PassengerCapacity { get; set; }
        public string TransmissionType { get; set; }
        public double EngineVolume { get; set; }
        public double MaxLandSpeed { get; set; }

        public void Drive()
        {
            Console.WriteLine("The motorcycle screams down the highway with the rider in sensible gear, of course.");
            Console.WriteLine("Press enter to continue.");
            Console.ReadKey();
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
