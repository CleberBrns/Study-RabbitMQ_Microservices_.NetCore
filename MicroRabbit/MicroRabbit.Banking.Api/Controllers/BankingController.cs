using MicroRabbit.Baking.Application.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BankingController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public BankingController(IAccountService accountService)
        {
            _accountService = accountService;
        }


        [HttpGet(Name = "GetAccounts")]
        public ActionResult<IEnumerable<Account>> GetAccounts()
        {
            return Ok(_accountService.GetAccounts());
        }
    }
}
