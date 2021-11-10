using Xunit;
using AutoFixture;

namespace DemoCode.Tests {
    public class NumberDemos {

        [Fact]
        public void Inits() {
            var sut = new IntCalculator();
            var fixture = new Fixture();
            var anonymousNember = fixture.Create<int>();

            sut.Subtract(anonymousNember);
            Assert.True(sut.Value < 0);
        }
    }
}
