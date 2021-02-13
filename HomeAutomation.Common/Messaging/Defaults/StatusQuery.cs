using HomeAutomation.Common.Messaging.BaseClasses;
using System;

namespace HomeAutomation.Common.Messaging.Defaults
{
    public class StatusQuery : QueryBase
    {
        public Guid TargetDeviceId { get; set; }
    }
}
