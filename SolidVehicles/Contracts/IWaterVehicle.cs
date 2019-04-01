using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles.Contracts
{
    public interface IWaterVehicle
    {
        double MaxWaterSpeed { get; set; }

        void Drive();

    }
}
