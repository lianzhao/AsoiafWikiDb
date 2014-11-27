// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.searchWhere
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Generated;

namespace LinqToWiki.Generated.Entities
{
  public sealed class searchWhere
  {
    /// <summary>
    /// The namespace(s) to enumerate
    /// 
    /// </summary>
    public ItemOrCollection<Namespace> ns { get; private set; }

    /// <summary>
    /// Search inside the text or titles
    /// 
    /// </summary>
    public searchwhat what { get; private set; }

    /// <summary>
    /// What metadata to return
    /// 
    /// </summary>
    public ItemOrCollection<searchinfo> info { get; private set; }

    /// <summary>
    /// Include redirect pages in the search
    /// 
    /// </summary>
    public bool redirects { get; private set; }

    private searchWhere()
    {
    }
  }
}
