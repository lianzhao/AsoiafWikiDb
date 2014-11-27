// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.backlinksWhere
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Generated;

namespace LinqToWiki.Generated.Entities
{
  public sealed class backlinksWhere
  {
    /// <summary>
    /// Title to search. Cannot be used together with blpageid
    /// 
    /// </summary>
    public string title { get; private set; }

    /// <summary>
    /// Pageid to search. Cannot be used together with bltitle
    /// 
    /// </summary>
    public long pageid { get; private set; }

    /// <summary>
    /// The namespace to enumerate
    /// 
    /// </summary>
    public ItemOrCollection<Namespace> ns { get; private set; }

    /// <summary>
    /// How to filter for redirects. If set to nonredirects when blredirect is enabled, this is only applied to the second level
    /// 
    /// </summary>
    public backlinksfilterredir filterredir { get; private set; }

    /// <summary>
    /// If linking page is a redirect, find all pages that link to that redirect as well. Maximum limit is halved.
    /// 
    /// </summary>
    public bool redirect { get; private set; }

    private backlinksWhere()
    {
    }
  }
}
