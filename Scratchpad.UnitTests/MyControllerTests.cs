using AutoFixture;
using AutoFixture.AutoMoq;
using Moq;
using Scratchpad.Command;
using Scratchpad.Library;
using Xunit;

namespace Scratchpad.UnitTests
{
    public class MyControllerTests
    {
        private Fixture _fixture;

        public MyControllerTests()
        {
            _fixture = new Fixture();
            _fixture.Customize(new AutoMoqCustomization());
        }

        [Fact]
        public void DoSomething_InvokesServiceMethod()
        {
            var service = _fixture.Freeze<Mock<IMyService>>();
            var sut = _fixture.Create<MyController>();
            sut.DoSomething();

            service.Verify(s => s.DoTest(), Times.Once);
        }
    }
}