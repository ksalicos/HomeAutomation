using System;
using System.Collections.Generic;
using System.Text;
using HomeAutomation.Common.Locations;

namespace HomeAutomation.Common.Devices
{
    public interface IDevice
    {
        ILocation Location { get; }
    }
}
