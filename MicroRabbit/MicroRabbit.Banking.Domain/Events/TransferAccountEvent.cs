using MicroRabbit.Domain.Core;

namespace MicroRabbit.Banking.Domain.Events
{
    public class TransferAccountEvent : Event
    {
        public int From { get; private set; }
        public int To { get; private set; }
        public decimal TransferAmount { get; private set; }

        public TransferAccountEvent(int from, int to, decimal transferAmount)
        {
            From = from;
            To = to;
            TransferAmount = transferAmount;
        }
    }
}
