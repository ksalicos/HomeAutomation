using HomeAutomation.Common.Devices;
using HomeAutomation.Common.Enums;
using System;

namespace HomeAutomation.Devices.Button
{
    public class ButtonState : IDeviceState
    {
        public DateTimeOffset Timestamp { get; set; }
        public DeviceStatus Status { get; set; }
        public bool Pressed { get; set; }
    }
}
