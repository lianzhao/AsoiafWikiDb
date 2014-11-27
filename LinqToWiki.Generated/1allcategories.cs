// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.allcategoriesWhere
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

namespace LinqToWiki.Generated.Entities
{
  public sealed class allcategoriesWhere
  {
    /// <summary>
    /// The category to start enumerating from
    /// 
    /// </summary>
    public string from { get; private set; }

    /// <summary>
    /// The category to stop enumerating at
    /// 
    /// </summary>
    public string to { get; private set; }

    /// <summary>
    /// Search for all category titles that begin with this value
    /// 
    /// </summary>
    public string prefix { get; private set; }

    /// <summary>
    /// Minimum number of category members
    /// 
    /// </summary>
    public int min { get; private set; }

    /// <summary>
    /// Maximum number of category members
    /// 
    /// </summary>
    public int max { get; private set; }

    private allcategoriesWhere()
    {
    }
  }
}
