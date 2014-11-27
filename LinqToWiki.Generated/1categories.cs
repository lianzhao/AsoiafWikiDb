// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.categoriesWhere
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Collections;
using LinqToWiki.Generated;

namespace LinqToWiki.Generated.Entities
{
  public sealed class categoriesWhere
  {
    /// <summary>
    /// Which kind of categories to show
    /// 
    /// </summary>
    public ItemOrCollection<categoriesshow> show { get; private set; }

    /// <summary>
    /// Only list these categories. Useful for checking whether a certain page is in a certain category
    /// 
    /// </summary>
    public ItemOrCollection<string> categories { get; private set; }

    private categoriesWhere()
    {
    }
  }
}
