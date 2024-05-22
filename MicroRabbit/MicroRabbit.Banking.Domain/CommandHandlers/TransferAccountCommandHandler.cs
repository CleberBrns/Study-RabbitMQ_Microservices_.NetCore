using MediatR;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Events;
using MicroRabbit.Domain.Core.Bus;

namespace MicroRabbit.Banking.Domain.CommandHandlers
{
    public class TransferAccountCommandHandler : IRequestHandler<CreateAccountTransferCommand, bool>
    {
        private readonly IEventBus _eventBus;

        public TransferAccountCommandHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public Task<bool> Handle(CreateAccountTransferCommand request, CancellationToken cancellationToken)
        {
            //publish event to RabbitMQ
            _eventBus.Publish(new TransferAccountEvent(request.From, request.To, request.TransferAmount));

            return Task.FromResult(true);
        }
    }
}
