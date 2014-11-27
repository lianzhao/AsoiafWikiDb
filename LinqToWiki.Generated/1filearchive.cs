// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.filearchiveWhere
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

namespace LinqToWiki.Generated.Entities
{
  public sealed class filearchiveWhere
  {
    /// <summary>
    /// The image title to start enumerating from
    /// 
    /// </summary>
    public string from { get; private set; }

    /// <summary>
    /// The image title to stop enumerating at
    /// 
    /// </summary>
    public string to { get; private set; }

    /// <summary>
    /// Search for all image titles that begin with this value
    /// 
    /// </summary>
    public string prefix { get; private set; }

    /// <summary>
    /// SHA1 hash of image. Overrides fasha1base36
    /// 
    /// </summary>
    public string sha1 { get; private set; }

    /// <summary>
    /// SHA1 hash of image in base 36 (used in MediaWiki)
    /// 
    /// </summary>
    public string sha1base36 { get; private set; }

    private filearchiveWhere()
    {
    }
  }
}
