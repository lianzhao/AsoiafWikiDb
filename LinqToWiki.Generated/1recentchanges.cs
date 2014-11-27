// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.recentchangesWhere
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Generated;
using System;

namespace LinqToWiki.Generated.Entities
{
  public sealed class recentchangesWhere
  {
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
    /// Filter log entries to only this namespace(s)
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
    /// Only list changes tagged with this tag
    /// 
    /// </summary>
    public string tag { get; private set; }

    /// <summary>
    /// Which tokens to obtain for each change
    /// 
    /// </summary>
    public ItemOrCollection<recentchangestoken> token { get; private set; }

    /// <summary>
    /// Show only items that meet this criteria.
    ///             For example, to see only minor edits done by logged-in users, set rcshow=minor|!anon
    /// 
    /// </summary>
    public ItemOrCollection<recentchangesshow> show { get; private set; }

    /// <summary>
    /// Which types of changes to show
    /// 
    /// </summary>
    public ItemOrCollection<recentchangestype2> type { get; private set; }

    /// <summary>
    /// Only list changes which are the latest revision
    /// 
    /// </summary>
    public bool toponly { get; private set; }

    private recentchangesWhere()
    {
    }
  }
}
