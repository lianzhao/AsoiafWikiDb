// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.allusersWhere
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Collections;
using LinqToWiki.Generated;

namespace LinqToWiki.Generated.Entities
{
  public sealed class allusersWhere
  {
    /// <summary>
    /// The user name to start enumerating from
    /// 
    /// </summary>
    public string from { get; private set; }

    /// <summary>
    /// The user name to stop enumerating at
    /// 
    /// </summary>
    public string to { get; private set; }

    /// <summary>
    /// Search for all users that begin with this value
    /// 
    /// </summary>
    public string prefix { get; private set; }

    /// <summary>
    /// Limit users to given group name(s)
    /// 
    /// </summary>
    public ItemOrCollection<allusersgroup> group { get; private set; }

    /// <summary>
    /// Exclude users in given group name(s)
    /// 
    /// </summary>
    public ItemOrCollection<allusersgroup> excludegroup { get; private set; }

    /// <summary>
    /// Limit users to given right(s) (does not include rights granted by implicit or auto-promoted groups like *, user, or autoconfirmed)
    /// 
    /// </summary>
    public ItemOrCollection<allusersrights> rights { get; private set; }

    /// <summary>
    /// Only list users who have made edits
    /// 
    /// </summary>
    public bool witheditsonly { get; private set; }

    /// <summary>
    /// Only list users active in the last 30 days(s)
    /// 
    /// </summary>
    public bool activeusers { get; private set; }

    private allusersWhere()
    {
    }
  }
}
