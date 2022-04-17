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

    [TestMethod]
    public void HubSpotConfig_ShouldImplementKeyHolder()
    {
        // Arrange
        // Act
        var hubSpotConfig = new HubSpotConfig();
        // Assert
        hubSpotConfig.Should().BeAssignableTo<IKeyHolder>();
    }
    
    [TestMethod]
    public void HubSpotConfig_ShouldHaveEmptyStringKey()
    {
        // Arrange
        // Act
        var hubSpotConfig = new HubSpotConfig();
        // Assert
        hubSpotConfig.Key.Should().BeEmpty();
    }
    
    [TestMethod]
    public void Key_ShouldBeAssignable()
    {
        // Arrange
        const string key = "key";
        var hubSpotConfig = new HubSpotConfig();
        // Act
        hubSpotConfig.Key = key;
        // Assert
        hubSpotConfig.Key.Should().BeSameAs(key);
    }
    
}