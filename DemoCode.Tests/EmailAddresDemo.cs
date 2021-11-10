using Xunit;
using AutoFixture;
using System.Net.Mail;

namespace DemoCode.Tests {
    public class EmailAddresDemo {

        [Fact]
        public void Email() {
            // arrange
            var fixture = new Fixture();            
            var sut = new EmailMessage(fixture.Create<MailAddress>().Address, fixture.Create<string>(),fixture.Create<bool>());

            // act


        }
    }
}
