// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.videoinfoWhere
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using System;

namespace LinqToWiki.Generated.Entities
{
  public sealed class videoinfoWhere
  {
    /// <summary>
    /// Timestamp to start listing from
    /// 
    /// </summary>
    public DateTime start { get; private set; }

    /// <summary>
    /// Timestamp to stop listing at
    /// 
    /// </summary>
    public DateTime end { get; private set; }

    /// <summary>
    /// If viprop=url is set, a URL to an image scaled to this width will be returned.
    ///             For performance reasons if this option is used, no more than 50 scaled images will be returned.
    /// 
    /// </summary>
    public int urlwidth { get; private set; }

    /// <summary>
    /// Similar to viurlwidth.
    /// 
    /// </summary>
    public int urlheight { get; private set; }

    /// <summary>
    /// A handler specific parameter string. For example, pdf's
    ///             might use 'page15-100px'. viurlwidth must be used and be consistent with viurlparam
    /// 
    /// </summary>
    public string urlparam { get; private set; }

    private videoinfoWhere()
    {
    }
  }
}
