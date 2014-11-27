// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.imagesWhere
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Collections;

namespace LinqToWiki.Generated.Entities
{
  public sealed class imagesWhere
  {
    /// <summary>
    /// Only list these images. Useful for checking whether a certain page has a certain Image.
    /// 
    /// </summary>
    public ItemOrCollection<string> images { get; private set; }

    private imagesWhere()
    {
    }
  }
}
