// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.watchlistWhere
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Generated;
using System;

namespace LinqToWiki.Generated.Entities
{
  public sealed class watchlistWhere
  {
    /// <summary>
    /// Include multiple revisions of the same page within given timeframe
    /// 
    /// </summary>
    public bool allrev { get; private set; }

    /// <summary>
    /// The timestamp to start enumerating from
    /// 
    /// </summary>
    public DateTime start { get; private set; }

    /// <summary>
    /// The timestamp to end enumerating
    /// 
    /// </summary>
    public DateTime end { get; private set; }

    /// <summary>
    /// Filter changes to only the given namespace(s)
    /// 
    /// </summary>
    public ItemOrCollection<Namespace> ns { get; private set; }

    /// <summary>
    /// Only list changes by this user
    /// 
    /// </summary>
    public string user { get; private set; }

    /// <summary>
    /// Don't list changes by this user
    /// 
    /// </summary>
    public string excludeuser { get; private set; }

    /// <summary>
    /// Show only items that meet this criteria.
    ///             For example, to see only minor edits done by logged-in users, set wlshow=minor|!anon
    /// 
    /// </summary>
    public ItemOrCollection<watchlistshow> show { get; private set; }

    /// <summary>
    /// Which types of changes to show
    ///              edit           - Regular page edits
    ///              external       - External changes
    ///              new            - Page creations
    ///              log            - Log entries
    /// 
    /// </summary>
    public ItemOrCollection<watchlisttype2> type { get; private set; }

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

    private watchlistWhere()
    {
    }
  }
}
