using System;

namespace HomeAutomation.Common.Messaging.BaseClasses
{
    public abstract class MessageBase
    {
        public Guid MessageId { get; set; }
        public Guid DeviceId { get; set; }
    }
}
