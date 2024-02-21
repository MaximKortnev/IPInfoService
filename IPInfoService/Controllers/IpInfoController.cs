using IPInfoService.Services;
using Microsoft.AspNetCore.Mvc;


namespace IPInfoService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IpInfoController : ControllerBase
    {
        private readonly IIPInfoService iPInfoService;

        public IpInfoController(IIPInfoService iPInfoService)
        {
            this.iPInfoService = iPInfoService;
        }

        [HttpGet("{ipAddress}")]
        public async Task<IActionResult> GetIpInfo(string ipAddress)
        {
            // Делаем запрос к сервису ipinfo.io
            var client = new HttpClient();
            var apiUrl = $"https://ipinfo.io/{ipAddress}/geo";

            var response = await client.GetAsync(apiUrl);

            if (!response.IsSuccessStatusCode)
            {
                return StatusCode((int)response.StatusCode);
            }

            var responseBody = await response.Content.ReadAsStringAsync();

            iPInfoService.SaveRequestIp(ipAddress);

            return Content(responseBody, "application/json");
        }
    }
}
