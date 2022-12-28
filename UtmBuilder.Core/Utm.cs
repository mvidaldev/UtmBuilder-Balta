using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core;

public class Utm
{
    /// <summary>
    /// Website Link
    /// </summary>
    /// <param name="url">Website Link </param>
    /// <param name="campaign">Campaign Details</param>
    public Utm(Url url, Campaign campaign)
    {
        Url = url;
        Campaign = campaign;
    }

    public Url Url { get; }
    public Campaign Campaign { get; }



}