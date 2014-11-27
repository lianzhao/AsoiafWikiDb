// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.logeventsWhere
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Generated;
using System;

namespace LinqToWiki.Generated.Entities
{
  public sealed class logeventsWhere
  {
    /// <summary>
    /// Filter log entries to only this type
    /// 
    /// </summary>
    public logeventstype type { get; private set; }

    /// <summary>
    /// Filter log actions to only this type. Overrides letype
    /// 
    /// </summary>
    public logeventsaction action { get; private set; }

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
    /// Filter entries to those made by the given user
    /// 
    /// </summary>
    public string user { get; private set; }

    /// <summary>
    /// Filter entries to those related to a page
    /// 
    /// </summary>
    public string title { get; private set; }

    /// <summary>
    /// Filter entries that start with this prefix. Disabled in Miser Mode
    /// 
    /// </summary>
    public string prefix { get; private set; }

    /// <summary>
    /// Only list event entries tagged with this tag
    /// 
    /// </summary>
    public string tag { get; private set; }

    private logeventsWhere()
    {
    }
  }
}
