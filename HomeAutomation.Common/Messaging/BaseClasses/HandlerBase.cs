using CSharpFunctionalExtensions;
using HomeAutomation.Common.Devices;
using HomeAutomation.Common.Messaging.Interfaces;
using System.Threading.Tasks;

namespace HomeAutomation.Common.Messaging.BaseClasses
{
    public abstract class HandlerBase<T> : IMessageHandler<T> where T : IMessage
    {
        public abstract Task<IResult> Handle(T message, IDeviceState state, IMessageAcceptor emitter);
    }
}
