// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.iwbacklinksWhere
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

namespace LinqToWiki.Generated.Entities
{
  public sealed class iwbacklinksWhere
  {
    /// <summary>
    /// Prefix for the interwiki
    /// 
    /// </summary>
    public string prefix { get; private set; }

    /// <summary>
    /// Interwiki link to search for. Must be used with iwblprefix
    /// 
    /// </summary>
    public string title { get; private set; }

    private iwbacklinksWhere()
    {
    }
  }
}
