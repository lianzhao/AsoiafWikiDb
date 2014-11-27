// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.watchlistrawWhere
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Generated;

namespace LinqToWiki.Generated.Entities
{
  public sealed class watchlistrawWhere
  {
    /// <summary>
    /// Only list pages in the given namespace(s)
    /// 
    /// </summary>
    public ItemOrCollection<Namespace> ns { get; private set; }

    /// <summary>
    /// Only list items that meet these criteria
    /// 
    /// </summary>
    public ItemOrCollection<watchlistrawshow> show { get; private set; }

    /// <summary>
    /// The name of the user whose watchlist you'd like to access
    /// 
    /// </summary>
    public string owner { get; private set; }

    /// <summary>
    /// Give a security token (settable in preferences) to allow access to another user's watchlist
    /// 
    /// </summary>
    public string token { get; private set; }

    private watchlistrawWhere()
    {
    }
  }
}
