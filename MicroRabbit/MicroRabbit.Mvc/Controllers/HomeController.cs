using MicroRabbit.Mvc.Models;
using MicroRabbit.Mvc.Models.Dto;
using MicroRabbit.Mvc.ProxyServices.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MicroRabbit.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAccountTransferService _accountTransferService;

        public HomeController(IAccountTransferService accountTransferService)
        {
            _accountTransferService = accountTransferService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public async Task<IActionResult> AccountTransfer(TransferViewModel transfer)
        {
            var accountTransferDto = new AccountTransferDto
            {
                FromAccount = transfer.FromAccount,
                ToAccount = transfer.ToAccount,
                TransferAmount = transfer.TransferAmount
            };

            await _accountTransferService.AccountTransfer(accountTransferDto);

            return View("Index");
        }
    }
}
