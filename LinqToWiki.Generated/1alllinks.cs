// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.alllinksWhere
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki;

namespace LinqToWiki.Generated.Entities
{
  public sealed class alllinksWhere
  {
    /// <summary>
    /// The title of the link to start enumerating from
    /// 
    /// </summary>
    public string from { get; private set; }

    /// <summary>
    /// The title of the link to stop enumerating at
    /// 
    /// </summary>
    public string to { get; private set; }

    /// <summary>
    /// Search for all linked titles that begin with this value
    /// 
    /// </summary>
    public string prefix { get; private set; }

    /// <summary>
    /// Only show distinct linked titles. Cannot be used with alprop=ids.
    ///             When used as a generator, yields target pages instead of source pages.
    /// 
    /// </summary>
    public bool unique { get; private set; }

    /// <summary>
    /// The namespace to enumerate
    /// 
    /// </summary>
    public Namespace ns { get; private set; }

    private alllinksWhere()
    {
    }
  }
}
