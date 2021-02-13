using HomeAutomation.Common.Devices;
using HomeAutomation.Common.Messaging.BaseClasses;

namespace HomeAutomation.Common.Messaging.Defaults
{
    public class DeviceStateChangedEvent : EventBase
    {
        public IDeviceState State { get; set; }
    }
}
