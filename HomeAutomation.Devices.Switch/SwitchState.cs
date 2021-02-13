using HomeAutomation.Common.Devices;
using HomeAutomation.Common.Enums;
using System;

namespace HomeAutomation.Devices.Switch
{
    public class SwitchState : IDeviceState
    {
        public DateTimeOffset Timestamp { get; set; }
        public DeviceStatus Status { get; set; }
        public OnOff Position { get; set; }
    }
}
