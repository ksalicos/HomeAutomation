using System;

namespace HomeAutomation.Common.Devices
{
    public interface IDevice
    {
        Guid DeviceId { get; }
        Guid LocationId { get; }
        IDeviceState State { get; }
    }
}
