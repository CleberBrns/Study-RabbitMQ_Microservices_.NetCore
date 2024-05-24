using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _transferRepository;
        private readonly IEventBus _eventBus;

        public TransferService(ITransferRepository TransferRepository, IEventBus eventBus)
        {
            _transferRepository = TransferRepository;
            _eventBus = eventBus;
        }

        public IEnumerable<AccountTransferLog> GetAccountTransferLogs()
        {
            return _transferRepository.GetAccountTransferLogs();
        }

        //public void TransferFunds(TransferTransferDto TransferTransfer)
        //{
        //    var command = new CreateTransferCommand(
        //        TransferTransfer.FromTransfer,
        //        TransferTransfer.ToTransfer,
        //        TransferTransfer.TransferAmount
        //        );

        //    _eventBus.SendCommand(command);
        //}
    }
}
