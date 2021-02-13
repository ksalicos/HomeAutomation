using CSharpFunctionalExtensions;
using HomeAutomation.Common.Messaging.Interfaces;

namespace HomeAutomation.Common.Messaging.BaseClasses
{
    public abstract class MessageQueueBase : IMessageQueue
    {
        public abstract IResult AcceptMessage(IMessage message);
        public abstract IMessage Read();
    }
}
