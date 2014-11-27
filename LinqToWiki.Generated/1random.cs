// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.randomWhere
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki;
using LinqToWiki.Collections;

namespace LinqToWiki.Generated.Entities
{
  public sealed class randomWhere
  {
    /// <summary>
    /// Return pages in these namespaces only
    /// 
    /// </summary>
    public ItemOrCollection<Namespace> ns { get; private set; }

    /// <summary>
    /// Load a random redirect instead of a random page
    /// 
    /// </summary>
    public bool redirect { get; private set; }

    private randomWhere()
    {
    }
  }
}
