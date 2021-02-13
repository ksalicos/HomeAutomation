using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeAutomation.Common.Messaging.Interfaces;

namespace HomeAutomation.Messaging.Interfaces
{
    public interface IMessageQueue : IMessageAcceptor
    {
        IMessage Read();
    }
}
