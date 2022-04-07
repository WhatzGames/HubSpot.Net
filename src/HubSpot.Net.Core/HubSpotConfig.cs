namespace HubSpot.Net.Core;

internal class HubSpotConfig : IKeyHolder
{
    public string Key { get; set; }

    public HubSpotConfig()
    {
        Key = string.Empty;
    }
}