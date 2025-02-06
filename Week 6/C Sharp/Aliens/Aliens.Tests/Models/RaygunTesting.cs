using System;
using Xunit;
using Aliens.Models;

namespace Aliens.Tests.Models
{
    public class RaygunTests
    {
        [Fact]
        public void Constructor_InitializesPropertiesCorrectly()
        {
            // Arrange
            int maxCharge = 10;
            int currentCharge = 5;

            // Act
            Raygun raygun = new Raygun(maxCharge, currentCharge);

            // Assert
            Assert.Equal(maxCharge, raygun.MaxCharge);
            Assert.Equal(currentCharge, raygun.CurrentCharge);
        }

        [Fact]
        public void Recharge_IncreasesCurrentChargeByOne()
        {
            // Arrange
            Raygun raygun = new Raygun(10, 5);

            // Act
            raygun.Recharge();

            // Assert
            Assert.Equal(6, raygun.CurrentCharge);
        }

        [Fact]
        public void IsCharged_ReturnsTrue_WhenChargeIsGreaterThanZero()
        {
            // Arrange
            Raygun raygun = new Raygun(10, 5);

            // Act
            bool result = raygun.IsCharged();

            // Assert
            Assert.True(result, "Expected IsCharged() to return true when charge is greater than zero.");
        }

        [Fact]
        public void IsCharged_ReturnsFalse_WhenChargeIsZero()
        {
            // Arrange
            Raygun raygun = new Raygun(10, 0);

            // Act
            bool result = raygun.IsCharged();

            // Assert
            Assert.False(result, "Expected IsCharged() to return false when charge is zero.");
        }

        [Fact]
        public void IsFullyCharged_ReturnsTrue_WhenChargeEqualsMaxCharge()
        {
            // Arrange
            Raygun raygun = new Raygun(10, 10);

            // Act
            bool result = raygun.IsFullyCharged();

            // Assert
            Assert.True(result, "Expected IsFullyCharged() to return true when charge equals max charge.");
        }

        [Fact]
        public void IsFullyCharged_ReturnsFalse_WhenChargeIsLessThanMaxCharge()
        {
            // Arrange
            Raygun raygun = new Raygun(10, 5);

            // Act
            bool result = raygun.IsFullyCharged();

            // Assert
            Assert.False(result, "Expected IsFullyCharged() to return false when charge is less than max charge.");
        }
    }
}
