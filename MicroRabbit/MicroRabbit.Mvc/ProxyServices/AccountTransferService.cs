using MicroRabbit.Mvc.Models.Dto;
using MicroRabbit.Mvc.ProxyServices.Interfaces;
using Newtonsoft.Json;

namespace MicroRabbit.Mvc.ProxyServices
{
    public class AccountTransferService : IAccountTransferService
    {
        private readonly HttpClient _apiClient;

        public AccountTransferService(HttpClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task AccountTransfer(AccountTransferDto accountTransfer)
        {
            var uri = "https://localhost:7296/api/Banking";
            var transferContent = new StringContent(JsonConvert.SerializeObject(accountTransfer), 
                                                    System.Text.Encoding.UTF8,
                                                    "application/json");

            var response = await _apiClient.PostAsync(uri, transferContent);
            response.EnsureSuccessStatusCode();
;        }
    }
}
