// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.protectedtitlesWhere
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Generated;
using System;

namespace LinqToWiki.Generated.Entities
{
  public sealed class protectedtitlesWhere
  {
    /// <summary>
    /// Only list titles in these namespaces
    /// 
    /// </summary>
    public ItemOrCollection<Namespace> ns { get; private set; }

    /// <summary>
    /// Only list titles with these protection levels
    /// 
    /// </summary>
    public ItemOrCollection<protectedtitleslevel> level { get; private set; }

    /// <summary>
    /// Start listing at this protection timestamp
    /// 
    /// </summary>
    public DateTime start { get; private set; }

    /// <summary>
    /// Stop listing at this protection timestamp
    /// 
    /// </summary>
    public DateTime end { get; private set; }

    private protectedtitlesWhere()
    {
    }
  }
}
