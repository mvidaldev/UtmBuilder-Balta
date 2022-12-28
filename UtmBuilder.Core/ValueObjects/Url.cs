﻿using System.Text;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.ValueObjects;

public class Url : ValueObject
{
    /// <summary>
    /// Create a New URL
    /// </summary>
    /// <param name="address">Address of URL(WebSite Link)</param>
    public Url(string address)
    {
        Address = address;
        InvalidUrlException.ThrowIfInvalid(address);
    }
    /// <summary>
    /// Address of URL(WebSite Link)
    /// </summary>
    public string Address { get;  }


}