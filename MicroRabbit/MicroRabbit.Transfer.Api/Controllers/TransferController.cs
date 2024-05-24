using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Transfer.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransferController : ControllerBase
    {
        private readonly ITransferService _transferService;

        public TransferController(ITransferService transferService)
        {
            _transferService = transferService;
        }

        [HttpGet(Name = "GetAccountTransferLogs")]
        public  ActionResult<IEnumerable<AccountTransferLog>> GetAccountTransferLogs()
        {
            return Ok(_transferService.GetAccountTransferLogs());
        }
    }
}
