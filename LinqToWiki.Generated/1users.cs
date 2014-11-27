// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.usersWhere
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Collections;
using LinqToWiki.Generated;

namespace LinqToWiki.Generated.Entities
{
  public sealed class usersWhere
  {
    /// <summary>
    /// A list of users to obtain the same information for
    /// 
    /// </summary>
    public ItemOrCollection<string> users { get; private set; }

    /// <summary>
    /// Which tokens to obtain for each user
    /// 
    /// </summary>
    public ItemOrCollection<userstoken> token { get; private set; }

    private usersWhere()
    {
    }
  }
}
