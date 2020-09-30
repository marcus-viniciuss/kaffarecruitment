using System.Diagnostics;
using System.Threading.Tasks;
using ExternalApi;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using TesteKaffa.Models;

namespace TesteKaffa.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ServiceApi _serviceApi;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _serviceApi = new ServiceApi();
        }

        public async Task<IActionResult> IndexAsync()
        {
            var RestClient = await _serviceApi.Get();
            var model = new
            {
                currentDateTime = RestClient.datetime,
            };
            var RestServer = JsonConvert.SerializeObject(model);

            var result = new Result
            {
                DateTime = RestServer,
                Clock = RestClient
            };

            return View(result);
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
    }
}
