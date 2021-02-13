namespace HomeAutomation.Common.Messaging.Interfaces
{
    public interface IMessageQueue : IMessageAcceptor
    {
        IMessage Read();
    }
}
