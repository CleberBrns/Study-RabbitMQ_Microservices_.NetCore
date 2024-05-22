namespace MicroRabbit.Banking.Domain.Commands
{
    public class CreateAccountTransferCommand : TransferAccountCommand
    {
        public CreateAccountTransferCommand(int from, int to, decimal transferAmount)
        {
            From = from;
            To = to;
            TransferAmount = transferAmount;
        }
    }
}
