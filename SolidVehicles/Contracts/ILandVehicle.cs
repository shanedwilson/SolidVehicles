using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Contracts
{
    public interface ILandVehicle
    {
        double MaxLandSpeed { get; set; }

        void Drive();
    }
}
