// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.langlinksWhere
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

namespace LinqToWiki.Generated.Entities
{
  public sealed class langlinksWhere
  {
    /// <summary>
    /// Whether to get the full URL
    /// 
    /// </summary>
    public bool url { get; private set; }

    /// <summary>
    /// Language code
    /// 
    /// </summary>
    public string lang { get; private set; }

    /// <summary>
    /// Link to search for. Must be used with lllang
    /// 
    /// </summary>
    public string title { get; private set; }

    private langlinksWhere()
    {
    }
  }
}
