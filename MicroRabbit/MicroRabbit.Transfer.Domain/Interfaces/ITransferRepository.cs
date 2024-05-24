using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Domain.Interfaces
{
    public interface ITransferRepository
    {
        void Add(AccountTransferLog accountTransferLog);
        IEnumerable<AccountTransferLog> GetAccountTransferLogs();
    }
}
