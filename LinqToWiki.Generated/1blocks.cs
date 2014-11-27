// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.blocksWhere
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Collections;
using LinqToWiki.Generated;
using System;

namespace LinqToWiki.Generated.Entities
{
  public sealed class blocksWhere
  {
    /// <summary>
    /// The timestamp to start enumerating from
    /// 
    /// </summary>
    public DateTime start { get; private set; }

    /// <summary>
    /// The timestamp to stop enumerating at
    /// 
    /// </summary>
    public DateTime end { get; private set; }

    /// <summary>
    /// List of block IDs to list (optional)
    /// 
    /// </summary>
    public ItemOrCollection<int> ids { get; private set; }

    /// <summary>
    /// List of users to search for (optional)
    /// 
    /// </summary>
    public ItemOrCollection<string> users { get; private set; }

    /// <summary>
    /// Get all blocks applying to this IP or CIDR range, including range blocks.
    ///             Cannot be used together with bkusers. CIDR ranges broader than IPv4/16 or IPv6/19 are not accepted
    /// 
    /// </summary>
    public string ip { get; private set; }

    /// <summary>
    /// Show only items that meet this criteria.
    ///             For example, to see only indefinite blocks on IPs, set bkshow=ip|!temp
    /// 
    /// </summary>
    public ItemOrCollection<blocksshow> show { get; private set; }

    private blocksWhere()
    {
    }
  }
}
