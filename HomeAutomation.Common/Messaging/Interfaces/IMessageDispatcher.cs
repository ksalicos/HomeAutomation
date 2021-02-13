using CSharpFunctionalExtensions;

namespace HomeAutomation.Common.Messaging.Interfaces
{
    public interface IMessageDispatcher : IMessageAcceptor
    {
        IResult RegisterHandler<T>(IMessageHandler<T> handler) where T : IMessage;
    }
}
