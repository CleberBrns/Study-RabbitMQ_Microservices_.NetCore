using MicroRabbit.Baking.Application.Models.Dtos;
using MicroRabbit.Banking.Domain.Models;

namespace MicroRabbit.Baking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();

        void TransferFunds(AccountTransferDto accountTransfer);
    }
}
