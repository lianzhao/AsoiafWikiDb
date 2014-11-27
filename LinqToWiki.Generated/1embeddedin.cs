// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.embeddedinWhere
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Generated;

namespace LinqToWiki.Generated.Entities
{
  public sealed class embeddedinWhere
  {
    /// <summary>
    /// Title to search. Cannot be used together with eipageid
    /// 
    /// </summary>
    public string title { get; private set; }

    /// <summary>
    /// Pageid to search. Cannot be used together with eititle
    /// 
    /// </summary>
    public long pageid { get; private set; }

    /// <summary>
    /// The namespace to enumerate
    /// 
    /// </summary>
    public ItemOrCollection<Namespace> ns { get; private set; }

    /// <summary>
    /// How to filter for redirects
    /// 
    /// </summary>
    public embeddedinfilterredir filterredir { get; private set; }

    private embeddedinWhere()
    {
    }
  }
}
