using System;
using System.Collections.Generic;
using System.Text;
using CSharpFunctionalExtensions;
using HomeAutomation.Common.Messaging.Interfaces;
using IMessageQueue = HomeAutomation.Messaging.Interfaces.IMessageQueue;

namespace HomeAutomation.Messaging
{
    public abstract class MessageQueue : IMessageQueue
    {
        public abstract IResult AcceptMessage(IMessage message);
        public abstract IMessage Read();
    }
}
