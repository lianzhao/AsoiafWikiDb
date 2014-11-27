// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.linksWhere
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki;
using LinqToWiki.Collections;

namespace LinqToWiki.Generated.Entities
{
  public sealed class linksWhere
  {
    /// <summary>
    /// Show links in this namespace(s) only
    /// 
    /// </summary>
    public ItemOrCollection<Namespace> ns { get; private set; }

    /// <summary>
    /// Only list links to these titles. Useful for checking whether a certain page links to a certain title.
    /// 
    /// </summary>
    public ItemOrCollection<string> titles { get; private set; }

    private linksWhere()
    {
    }
  }
}
