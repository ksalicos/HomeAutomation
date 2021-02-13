using CSharpFunctionalExtensions;
using HomeAutomation.Common.Devices;
using System.Threading.Tasks;

namespace HomeAutomation.Common.Messaging.Interfaces
{
    public interface IMessageHandler<in T> where T : IMessage
    {
        Task<IResult> Handle(T message, IDeviceState state, IMessageAcceptor emitter);
    }
}
