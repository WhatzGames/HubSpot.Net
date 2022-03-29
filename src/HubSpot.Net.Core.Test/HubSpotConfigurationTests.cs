using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HubSpot.Net.Core.Test;

[TestClass]
public class HubSpotConfigurationTests
{
    [TestMethod]
    public void HubSpotConfig_ShouldInstantiate()
    {
        // Arrange
        // Act
        var hubSpotConfig = new HubSpotConfig();
        // Assert
        hubSpotConfig.Should().NotBeNull();
    }
}