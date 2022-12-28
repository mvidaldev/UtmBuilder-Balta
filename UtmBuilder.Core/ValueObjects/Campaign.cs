using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.ValueObjects;

public class Campaign : ValueObject
{
    
/// <summary>
/// Generate a new Campaign for the URL
/// </summary>
/// <param name="source">The Reffer eg: Google, youtube etc.</param>
/// <param name="medium">Marketing Medium eg:(cpc banner etc)</param>
/// <param name="name">Product, promo code or slogan etc</param>
/// <param name="id">The ads campaign ID</param>
/// <param name="term">Identify Paid keywords</param>
/// <param name="content">Use for differentiate campaigns</param>
    public Campaign(string source, string medium, string name, string? id = null, string? term = null, string? content = null)
    {
        Source = source;
        Medium = medium;
        Name = name;
        Id = id;
        Term = term;
        Content = content;

        InvalidCampaignException.ThrowIfInvalid(source,"Source is Invalid");
        InvalidCampaignException.ThrowIfInvalid(medium, "Medium is Invalid");
        InvalidCampaignException.ThrowIfInvalid(name, "Name is Invalid");

    }
    /// <summary>
    /// The Reffer eg: Google, youtube etc.
    /// </summary>
    public string Source { get; }
    
    /// <summary>
    /// Marketing Medium eg:(cpc banner etc)
    /// </summary>
    public string Medium { get; }
    
    /// <summary>
    /// Product, promo code or slogan etc
    /// </summary>
    public string Name { get;  }
    
    /// <summary>
    /// The ads campaign ID
    /// </summary>
    public string? Id { get; }
    
    /// <summary>
    /// Identify Paid keywords
    /// </summary>
    public string? Term { get; }

    /// <summary>
    /// Use for differentiate campaigns
    /// </summary>
    public string? Content { get;  }

}