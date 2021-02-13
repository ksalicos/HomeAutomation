using CSharpFunctionalExtensions;
using System;

namespace HomeAutomation.Common.Devices
{
    public interface IDeviceService
    {
        IResult RegisterDevice(IDevice device);
        Result<IDeviceState> GetDeviceState(Guid DeviceId);
    }
}
