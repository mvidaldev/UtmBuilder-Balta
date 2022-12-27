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
    }
    public string Source { get; }
    public string Medium { get; }
    public string Name { get;  }
    public string? Id { get; }
    public string? Term { get; }
    public string? Content { get;  }

}