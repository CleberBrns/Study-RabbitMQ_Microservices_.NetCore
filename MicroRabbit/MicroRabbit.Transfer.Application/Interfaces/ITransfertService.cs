using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<AccountTransferLog> GetAccountTransferLogs();
    }
}
