// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.allpagesWhere
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Generated;

namespace LinqToWiki.Generated.Entities
{
  public sealed class allpagesWhere
  {
    /// <summary>
    /// The page title to start enumerating from
    /// 
    /// </summary>
    public string from { get; private set; }

    /// <summary>
    /// The page title to stop enumerating at
    /// 
    /// </summary>
    public string to { get; private set; }

    /// <summary>
    /// Search for all page titles that begin with this value
    /// 
    /// </summary>
    public string prefix { get; private set; }

    /// <summary>
    /// The namespace to enumerate
    /// 
    /// </summary>
    public Namespace ns { get; private set; }

    /// <summary>
    /// Which pages to list
    /// 
    /// </summary>
    public allpagesfilterredir filterredir { get; private set; }

    /// <summary>
    /// Limit to pages with at least this many bytes
    /// 
    /// </summary>
    public int minsize { get; private set; }

    /// <summary>
    /// Limit to pages with at most this many bytes
    /// 
    /// </summary>
    public int maxsize { get; private set; }

    /// <summary>
    /// Limit to protected pages only
    /// 
    /// </summary>
    public ItemOrCollection<allpagesprtype> prtype { get; private set; }

    /// <summary>
    /// The protection level (must be used with apprtype= parameter)
    /// 
    /// </summary>
    public ItemOrCollection<allpagesprlevel> prlevel { get; private set; }

    /// <summary>
    /// Filter protections based on cascadingness (ignored when apprtype isn't set)
    /// 
    /// </summary>
    public allpagesprfiltercascade prfiltercascade { get; private set; }

    /// <summary>
    /// Filter based on whether a page has langlinks
    ///             Note that this may not consider langlinks added by extensions.
    /// 
    /// </summary>
    public allpagesfilterlanglinks filterlanglinks { get; private set; }

    /// <summary>
    /// Which protection expiry to filter the page on
    ///              indefinite - Get only pages with indefinite protection expiry
    ///              definite - Get only pages with a definite (specific) protection expiry
    ///              all - Get pages with any protections expiry
    /// 
    /// </summary>
    public allpagesprexpiry prexpiry { get; private set; }

    private allpagesWhere()
    {
    }
  }
}
