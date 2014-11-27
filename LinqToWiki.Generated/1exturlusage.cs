// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.exturlusageWhere
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Generated;

namespace LinqToWiki.Generated.Entities
{
  public sealed class exturlusageWhere
  {
    /// <summary>
    /// Protocol of the URL. If empty and euquery set, the protocol is http.
    ///             Leave both this and euquery empty to list all external links
    /// 
    /// </summary>
    public exturlusageprotocol protocol { get; private set; }

    /// <summary>
    /// Search string without protocol. See [[Special:LinkSearch]]. Leave empty to list all external links
    /// 
    /// </summary>
    public string query { get; private set; }

    /// <summary>
    /// The page namespace(s) to enumerate.
    ///             NOTE: Due to $wgMiserMode, using this may result in fewer than "eulimit" results
    ///             returned before continuing; in extreme cases, zero results may be returned
    /// 
    /// </summary>
    public ItemOrCollection<Namespace> ns { get; private set; }

    /// <summary>
    /// Expand protocol-relative URLs with the canonical protocol
    /// 
    /// </summary>
    public bool expandurl { get; private set; }

    private exturlusageWhere()
    {
    }
  }
}
