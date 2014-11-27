// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.revisionsWhere
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Collections;
using LinqToWiki.Generated;
using System;

namespace LinqToWiki.Generated.Entities
{
  public sealed class revisionsWhere
  {
    /// <summary>
    /// From which revision id to start enumeration (enum)
    /// 
    /// </summary>
    public long startid { get; private set; }

    /// <summary>
    /// Stop revision enumeration on this revid (enum)
    /// 
    /// </summary>
    public long endid { get; private set; }

    /// <summary>
    /// From which revision timestamp to start enumeration (enum)
    /// 
    /// </summary>
    public DateTime start { get; private set; }

    /// <summary>
    /// Enumerate up to this timestamp (enum)
    /// 
    /// </summary>
    public DateTime end { get; private set; }

    /// <summary>
    /// Only include revisions made by user (enum)
    /// 
    /// </summary>
    public string user { get; private set; }

    /// <summary>
    /// Exclude revisions made by user (enum)
    /// 
    /// </summary>
    public string excludeuser { get; private set; }

    /// <summary>
    /// Only list revisions tagged with this tag
    /// 
    /// </summary>
    public string tag { get; private set; }

    /// <summary>
    /// Expand templates in revision content (requires rvprop=content)
    /// 
    /// </summary>
    public bool expandtemplates { get; private set; }

    /// <summary>
    /// Generate XML parse tree for revision content (requires rvprop=content)
    /// 
    /// </summary>
    public bool generatexml { get; private set; }

    /// <summary>
    /// Parse revision content (requires rvprop=content).
    ///             For performance reasons if this option is used, rvlimit is enforced to 1.
    /// 
    /// </summary>
    public bool parse { get; private set; }

    /// <summary>
    /// Only retrieve the content of this section number
    /// 
    /// </summary>
    public string section { get; private set; }

    /// <summary>
    /// Which tokens to obtain for each revision
    /// 
    /// </summary>
    public ItemOrCollection<revisionstoken> token { get; private set; }

    /// <summary>
    /// Revision ID to diff each revision to.
    ///             Use "prev", "next" and "cur" for the previous, next and current revision respectively
    /// 
    /// </summary>
    public string diffto { get; private set; }

    /// <summary>
    /// Text to diff each revision to. Only diffs a limited number of revisions.
    ///             Overrides rvdiffto. If rvsection is set, only that section will be diffed against this text
    /// 
    /// </summary>
    public string difftotext { get; private set; }

    /// <summary>
    /// Serialization format used for difftotext and expected for output of content
    /// 
    /// </summary>
    public revisionscontentformat contentformat { get; private set; }

    private revisionsWhere()
    {
    }
  }
}
