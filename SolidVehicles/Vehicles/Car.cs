using SolidVehicles.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Vehicles
{
    class Car : IVehicle, ILandVehicle
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
            Console.WriteLine("The car glided down the highway with the grace of a young Barishnakov.");
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
