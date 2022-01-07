using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

using MinimalIoC.AnyLayer;

namespace MinimalIoC.PreviousDotNetCoreUI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IGreeter _service;

        public IndexModel(ILogger<IndexModel> logger, IGreeter service)
            => (_logger, _service) = (logger, service);

        public string GreetingMessage { get; set; }
        public void OnGet() => GreetingMessage = _service.Greet();
    }
}
