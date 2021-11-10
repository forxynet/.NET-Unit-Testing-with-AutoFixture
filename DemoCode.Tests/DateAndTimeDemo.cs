using Xunit;
using AutoFixture;
using System;

namespace DemoCode.Tests {
    public class DateAndTimeDemo {
        [Fact]
        public void TestDateAndTime() {
            // arrange
            var fixture = new Fixture();
            DateTime logTime = new DateTime(2020, 1, 21);

            // act
            LogMessage result = LogMessageCreator.Create(fixture.Create<string>(), logTime);

            // assert
            Assert.Equal(logTime.Year, result.Year);
        }

        [Fact]
        public void TimeStamps() {
            // arrange
            var fixture = new Fixture();
            TimeSpan timeSpan = fixture.Create<TimeSpan>();

            //act

        }
    }
}
