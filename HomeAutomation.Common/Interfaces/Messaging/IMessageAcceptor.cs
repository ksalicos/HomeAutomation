using System;
using System.Collections.Generic;
using System.Text;
using CSharpFunctionalExtensions;

namespace HomeAutomation.Common.Interfaces.Messaging
{
    public interface IMessageAcceptor
    {
        IResult AcceptMessage(IMessage message);
    }
}
