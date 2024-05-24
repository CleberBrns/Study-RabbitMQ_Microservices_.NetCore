using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Events;

namespace MicroRabbit.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferAccountEvent>
    {
        public TransferEventHandler()
        {

        }

        public Task Handle(TransferAccountEvent @event)
        {
            return Task.CompletedTask;
        }
    }
}
