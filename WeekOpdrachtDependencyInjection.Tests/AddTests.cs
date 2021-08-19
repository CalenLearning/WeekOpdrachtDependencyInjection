using System;
using Xunit;
using WeekOpdrachtDependencyInjection.Business;

namespace WeekOpdrachtDependencyInjection.Tests
{
    public class AddTests
    {
        [Fact]
        public void Should_Be6Dot1415926535897931()
        {
            // Arrange
            CalculatePiService calculatePiService = new();
            double result;

            // Act
            result = calculatePiService.Add(3);

            // Assert
            Assert.Equal((Math.PI + 3), result);
        }

        [Fact]
        public void Should_Be105Dot1415926535897931()
        {
            // Arrange
            CalculatePiService calculatePiService = new();
            double result;

            // Act
            result = calculatePiService.Add(102);

            // Assert
            Assert.Equal((Math.PI + 102), result);
        }
    }
}
