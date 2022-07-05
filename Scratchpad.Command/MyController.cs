using Scratchpad.Library;

namespace Scratchpad.Command
{
    public class MyController
    {
        private readonly IMyService _myService;

        public MyController(
            IMyService myService)
        {
            _myService = myService;
        }

        public void DoSomething()
        {
            var result = _myService.DoTest();

        }
    }
}