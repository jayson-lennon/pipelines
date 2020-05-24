using System;
using Xunit;

namespace TestApi
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var w = new citest.WeatherForecast();
            w.Summary = "a summary";

            Assert.True(w.GtZero(5));

            Assert.False(w.GtZero(0));
        }
    }
}
