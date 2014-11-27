// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.deletedrevsWhere
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki;
using System;

namespace LinqToWiki.Generated.Entities
{
  public sealed class deletedrevsWhere
  {
    /// <summary>
    /// The timestamp to start enumerating from (1, 2)
    /// 
    /// </summary>
    public DateTime start { get; private set; }

    /// <summary>
    /// The timestamp to stop enumerating at (1, 2)
    /// 
    /// </summary>
    public DateTime end { get; private set; }

    /// <summary>
    /// Start listing at this title (3)
    /// 
    /// </summary>
    public string from { get; private set; }

    /// <summary>
    /// Stop listing at this title (3)
    /// 
    /// </summary>
    public string to { get; private set; }

    /// <summary>
    /// Search for all page titles that begin with this value (3)
    /// 
    /// </summary>
    public string prefix { get; private set; }

    /// <summary>
    /// List only one revision for each page (3)
    /// 
    /// </summary>
    public bool unique { get; private set; }

    /// <summary>
    /// Only list revisions by this user
    /// 
    /// </summary>
    public string user { get; private set; }

    /// <summary>
    /// Don't list revisions by this user
    /// 
    /// </summary>
    public string excludeuser { get; private set; }

    /// <summary>
    /// Only list pages in this namespace (3)
    /// 
    /// </summary>
    public Namespace ns { get; private set; }

    private deletedrevsWhere()
    {
    }
  }
}
