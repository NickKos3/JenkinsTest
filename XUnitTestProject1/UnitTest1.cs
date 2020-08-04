using System;
using WebApi_1.Services;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var temperatureHints = new TemperatureHints();

            Assert.Equal(temperatureHints.GetHintDependOnTemperature(3), "warm");
            Assert.Equal(temperatureHints.GetHintDependOnTemperature(5), "warm");
        }
    }
}
