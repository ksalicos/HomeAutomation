using CSharpFunctionalExtensions;
using HomeAutomation.Common.Messaging.Interfaces;
using System;
using System.Collections.Generic;

namespace HomeAutomation.Messaging
{
    public class InMemoryMessageQueue : IMessageQueue
    {
        private readonly Queue<IMessage> _messages = new Queue<IMessage>();

        public IResult AcceptMessage(IMessage message)
        {
            try
            {
                _messages.Enqueue(message);
                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Failure(ex.Message);
            }
        }

        public IMessage Read()
        {
            return _messages.Dequeue();
        }
    }
}
