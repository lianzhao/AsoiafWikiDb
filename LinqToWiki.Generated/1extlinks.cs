// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.extlinksWhere
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Generated;

namespace LinqToWiki.Generated.Entities
{
  public sealed class extlinksWhere
  {
    /// <summary>
    /// Protocol of the URL. If empty and elquery set, the protocol is http.
    ///             Leave both this and elquery empty to list all external links
    /// 
    /// </summary>
    public extlinksprotocol protocol { get; private set; }

    /// <summary>
    /// Search string without protocol. Useful for checking whether a certain page contains a certain external url
    /// 
    /// </summary>
    public string query { get; private set; }

    /// <summary>
    /// Expand protocol-relative URLs with the canonical protocol
    /// 
    /// </summary>
    public bool expandurl { get; private set; }

    private extlinksWhere()
    {
    }
  }
}
