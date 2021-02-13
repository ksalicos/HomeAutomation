using CSharpFunctionalExtensions;

namespace HomeAutomation.Common.Messaging.Interfaces
{
    public interface IMessageAcceptor
    {
        IResult AcceptMessage(IMessage message);
    }
}
