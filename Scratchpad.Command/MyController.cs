using Microsoft.Extensions.Logging;
using Scratchpad.Library;

namespace Scratchpad.Command
{
    public class MyController
    {
        private readonly ILogger _logger;
        private readonly IMyService _myService;

        public MyController(
            ILogger<MyController> logger,
            IMyService myService)
        {
            _logger = logger;
            _myService = myService;
        }

        public void DoSomething()
        {
            _logger.LogDebug("Invoked DoSomething");
            var result = _myService.DoTest();

        }
    }
}