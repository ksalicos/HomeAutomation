using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAutomation.Common.Interfaces.Messaging
{
    public interface IMessage
    {
        Guid Id { get; }
    }
}
