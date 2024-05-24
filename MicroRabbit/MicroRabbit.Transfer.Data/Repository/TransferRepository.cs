using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private readonly TransferDbContext _ctx;

        public TransferRepository(TransferDbContext ctx)
        {
            _ctx = ctx;
        }

        public void Add(AccountTransferLog accountTransferLog)
        {
            _ctx.Add(accountTransferLog);
            _ctx.SaveChanges();
        }

        public IEnumerable<AccountTransferLog> GetAccountTransferLogs()
        {
            return _ctx.AccountTransferLogs;
        }
    }
}
