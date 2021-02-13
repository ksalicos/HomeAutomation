using HomeAutomation.Common.Devices;
using System;

namespace HomeAutomation.Common.Messaging.Defaults
{
    public class StatusResponse
    {
        public Guid DeviceId { get; set; }
        public IDeviceState State { get; set; }
    }
}
