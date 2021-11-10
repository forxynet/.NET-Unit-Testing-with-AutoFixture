using Xunit;
using AutoFixture;

namespace DemoCode.Tests {
    public class StringDemos {

        [Fact]
        public void BasicStrings() {
            
            // arrange
            var fixture = new Fixture();
            var sut = new NameJoiner();

            var firstName = fixture.Create("First_");
            var lastName = fixture.Create("Last_");

            // act
            var result = sut.Join(firstName, lastName);

            //asert
            Assert.Equal(firstName + ' ' + lastName, result);
        }

        [Fact]
        public void Chars() {

            // arrenge 
            var fixture = new Fixture();

            var anonChar = fixture.Create<char>();

            // act

        }
    }
}
