using CSharpFunctionalExtensions;
using HomeAutomation.Common.Devices;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeAutomation.DeviceManager
{
    public class DeviceService : IDeviceService
    {
        private readonly List<IDevice> _devices = new List<IDevice>();

        public IResult RegisterDevice(IDevice device)
        {
            if (_devices.Any(x => x.DeviceId == device.DeviceId))
            {
                return Result.Failure($"Device with ID:{device.DeviceId} already registered.");
            }

            _devices.Add(device);
            return Result.Success();
        }

        public Result<IDeviceState> GetDeviceState(Guid deviceId)
        {
            var device = _devices.SingleOrDefault(x => x.DeviceId == deviceId);
            return device == null
                ? Result.Failure<IDeviceState>($"Device with Id:{deviceId} not registered")
                : Result.Success(device.State);
        }
    }
}
