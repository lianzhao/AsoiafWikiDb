// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.usercontribsWhere
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Generated;
using System;

namespace LinqToWiki.Generated.Entities
{
  public sealed class usercontribsWhere
  {
    /// <summary>
    /// The start timestamp to return from
    /// 
    /// </summary>
    public DateTime start { get; private set; }

    /// <summary>
    /// The end timestamp to return to
    /// 
    /// </summary>
    public DateTime end { get; private set; }

    /// <summary>
    /// The users to retrieve contributions for
    /// 
    /// </summary>
    public ItemOrCollection<string> user { get; private set; }

    /// <summary>
    /// Retrieve contributions for all users whose names begin with this value. Overrides ucuser
    /// 
    /// </summary>
    public string userprefix { get; private set; }

    /// <summary>
    /// Only list contributions in these namespaces
    /// 
    /// </summary>
    public ItemOrCollection<Namespace> ns { get; private set; }

    /// <summary>
    /// Show only items that meet this criteria, e.g. non minor edits only: ucshow=!minor
    ///             NOTE: if ucshow=patrolled or ucshow=!patrolled is set, revisions older than $wgRCMaxAge (2592000) won't be shown
    /// 
    /// </summary>
    public ItemOrCollection<usercontribsshow> show { get; private set; }

    /// <summary>
    /// Only list revisions tagged with this tag
    /// 
    /// </summary>
    public string tag { get; private set; }

    /// <summary>
    /// Only list changes which are the latest revision
    /// 
    /// </summary>
    public bool toponly { get; private set; }

    private usercontribsWhere()
    {
    }
  }
}
