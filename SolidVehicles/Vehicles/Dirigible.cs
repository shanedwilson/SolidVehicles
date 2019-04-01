using SolidVehicles.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Vehicles
{
    class Dirigible : IVehicle, IAirVehicle
    {
        public string Name { get; set; }
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int PassengerCapacity { get; set; }
        public bool Winged { get; set; } = true;
        public string TransmissionType { get; set; }
        public double EngineVolume { get; set; }
        public double MaxAirSpeed { get; set; }

        public void Start()
        {
            Console.WriteLine(" accelerates down the runway before climbing into the air.");
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();
        }

        public void Fly()
        {
            Console.WriteLine("The diribible effortlessly glides through the clouds like a gleaming god of the Sun, until it gets to close and burts into flames.");
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();
        }

        public void Stop()
        {
            Console.WriteLine("Upon touchdown, the airplane hits the brakes and reverses its engines.");
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();
        }
    }
}
