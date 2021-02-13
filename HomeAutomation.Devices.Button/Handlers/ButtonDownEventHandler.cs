using CSharpFunctionalExtensions;
using HomeAutomation.Common.Devices;
using HomeAutomation.Common.Messaging.BaseClasses;
using HomeAutomation.Common.Messaging.Defaults;
using HomeAutomation.Common.Messaging.Interfaces;
using HomeAutomation.Devices.Button.Events;
using System;
using System.Threading.Tasks;

namespace HomeAutomation.Devices.Button.Handlers
{
    public class ButtonDownEventHandler : HandlerBase<ButtonDownEvent>
    {
        public override async Task<IResult> Handle(ButtonDownEvent message, IDeviceState state, IMessageAcceptor emitter)
        {
            if (!(state is ButtonState buttonState)) return Result.Failure("Invalid State");

            if (!buttonState.Pressed)
            {
                buttonState.Pressed = true;
                emitter.AcceptMessage(new DeviceStateChangedEvent
                {
                    DeviceId = message.DeviceId,
                    MessageId = Guid.NewGuid(),
                    State = state
                });
            }

            return Result.Success();
        }
    }
}
