using System;
using System.Collections.Generic;
using System.Text;
using CSharpFunctionalExtensions;
using HomeAutomation.Common.Interfaces.Messaging;
using HomeAutomation.Messaging.Interfaces;

namespace HomeAutomation.Messaging
{
    public abstract class MessageQueue : IMessageQueue
    {
        public abstract IResult AcceptMessage(IMessage message);
        public abstract IMessage Read();
    }
}
