using System;
using Xunit;
using WeekOpdrachtDependencyInjection.Business;

namespace WeekOpdrachtDependencyInjection.Tests
{
    public class MinusTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(100)]
        public void Should_Be2Dot1415926535897931(int i)
        {
            // Arrange
            CalculatePiService calculatePiService = new();
            double result;

            // Act
            result = calculatePiService.Minus(i);

            // Assert
            Assert.Equal((Math.PI - i), result);
        }
    }
}
