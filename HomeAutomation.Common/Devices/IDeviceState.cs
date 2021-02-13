using HomeAutomation.Common.Enums;
using System;

namespace HomeAutomation.Common.Devices
{
    public interface IDeviceState
    {
        DateTimeOffset Timestamp { get; }
        DeviceStatus Status { get; }
    }
}
