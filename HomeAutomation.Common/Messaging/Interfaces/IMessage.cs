using System;

namespace HomeAutomation.Common.Messaging.Interfaces
{
    public interface IMessage
    {
        string MessageType { get => this.GetType().Name; }
        Guid MessageId { get; }
        Guid DeviceId { get; }
    }
}
