using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Contracts
{
    public interface IAirVehicle
    {
        double MaxAirSpeed { get; set; }
        bool Winged { get; set; }

        void Fly();
    }
}
