// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.templatesWhere
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki;
using LinqToWiki.Collections;

namespace LinqToWiki.Generated.Entities
{
  public sealed class templatesWhere
  {
    /// <summary>
    /// Show templates in this namespace(s) only
    /// 
    /// </summary>
    public ItemOrCollection<Namespace> ns { get; private set; }

    /// <summary>
    /// Only list these templates. Useful for checking whether a certain page uses a certain template.
    /// 
    /// </summary>
    public ItemOrCollection<string> templates { get; private set; }

    private templatesWhere()
    {
    }
  }
}
