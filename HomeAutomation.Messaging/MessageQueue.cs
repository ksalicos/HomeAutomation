using System;
using System.Collections.Generic;
using System.Text;
using CSharpFunctionalExtensions;
using HomeAutomation.Common.Interfaces.Messaging;

namespace HomeAutomation.Messaging
{
    public abstract class MessageQueue : IMessageAcceptor
    {
        public abstract IResult AcceptMessage(IMessage message);
    }
}
