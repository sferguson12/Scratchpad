using System;
using Microsoft.Extensions.Logging;

namespace Scratchpad.Library
{
    public class MyService : IMyService
    {
        private readonly ILogger _logger;

        public MyService(
            ILogger<MyService> logger)
        {
            _logger = logger;
        }

        public int DoTest()
        {
            _logger.LogDebug("Invoked DoTest");
            throw new NotImplementedException();
        }
    }
}
