using HomeAutomation.Common.Messaging.Interfaces;
using System;

namespace HomeAutomation.Common.Messaging.BaseClasses
{
    public class CommandBase : MessageBase, ICommand
    {
        public Guid TargetDeviceId { get; set; }
    }
}
