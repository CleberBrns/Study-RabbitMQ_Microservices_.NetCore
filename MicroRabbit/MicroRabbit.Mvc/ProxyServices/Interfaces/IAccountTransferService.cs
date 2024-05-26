using MicroRabbit.Mvc.Models.Dto;

namespace MicroRabbit.Mvc.ProxyServices.Interfaces
{
    public interface IAccountTransferService
    {
        Task AccountTransfer(AccountTransferDto accountTransfer);
    }
}