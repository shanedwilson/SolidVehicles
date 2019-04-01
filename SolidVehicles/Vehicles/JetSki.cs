using SolidVehicles.Contracts;
using System;

namespace SolidVehicles.Vehicles
{
    public class JetSki : IVehicle, IWaterVehicle
    {
        public string Name { get; set; }
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int PassengerCapacity { get; set; }
        public bool Winged { get; set; } = false;
        public string TransmissionType { get; set; }
        public double EngineVolume { get; set; }
        public double MaxWaterSpeed { get; set; }

        public void Drive()
        {
            Console.WriteLine("The jetski zips through the waves with the greatest of ease");
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
