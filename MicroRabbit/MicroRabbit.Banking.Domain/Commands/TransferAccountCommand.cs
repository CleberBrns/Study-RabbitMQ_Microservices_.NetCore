using MicroRabbit.Domain.Core.Commands;

namespace MicroRabbit.Banking.Domain.Commands
{
    public abstract class TransferAccountCommand : Command
    {
        public int From { get; protected set; }
        public int To { get; protected set; }
        public decimal TransferAmount { get; protected set; }
    }
}
