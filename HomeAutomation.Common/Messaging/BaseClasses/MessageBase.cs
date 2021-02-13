using System;

namespace HomeAutomation.Common.Messaging.BaseClasses
{
    public abstract class MessageBase
    {
        public Guid MessageId { get; set; }

        // The Id of the device producing this message.
        public Guid DeviceId { get; set; }
    }
}
