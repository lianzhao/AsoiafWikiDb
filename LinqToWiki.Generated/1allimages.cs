// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.allimagesWhere
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Generated;
using System;

namespace LinqToWiki.Generated.Entities
{
  public sealed class allimagesWhere
  {
    /// <summary>
    /// The image title to start enumerating from. Can only be used with aisort=name
    /// 
    /// </summary>
    public string from { get; private set; }

    /// <summary>
    /// The image title to stop enumerating at. Can only be used with aisort=name
    /// 
    /// </summary>
    public string to { get; private set; }

    /// <summary>
    /// The timestamp to start enumerating from. Can only be used with aisort=timestamp
    /// 
    /// </summary>
    public DateTime start { get; private set; }

    /// <summary>
    /// The timestamp to end enumerating. Can only be used with aisort=timestamp
    /// 
    /// </summary>
    public DateTime end { get; private set; }

    /// <summary>
    /// Search for all image titles that begin with this value. Can only be used with aisort=name
    /// 
    /// </summary>
    public string prefix { get; private set; }

    /// <summary>
    /// Limit to images with at least this many bytes
    /// 
    /// </summary>
    public int minsize { get; private set; }

    /// <summary>
    /// Limit to images with at most this many bytes
    /// 
    /// </summary>
    public int maxsize { get; private set; }

    /// <summary>
    /// SHA1 hash of image. Overrides aisha1base36
    /// 
    /// </summary>
    public string sha1 { get; private set; }

    /// <summary>
    /// SHA1 hash of image in base 36 (used in MediaWiki)
    /// 
    /// </summary>
    public string sha1base36 { get; private set; }

    /// <summary>
    /// Only return files uploaded by this user. Can only be used with aisort=timestamp. Cannot be used together with aifilterbots
    /// 
    /// </summary>
    public string user { get; private set; }

    /// <summary>
    /// How to filter files uploaded by bots. Can only be used with aisort=timestamp. Cannot be used together with aiuser
    /// 
    /// </summary>
    public allimagesfilterbots filterbots { get; private set; }

    /// <summary>
    /// What MIME type to search for. e.g. image/jpeg. Disabled in Miser Mode
    /// 
    /// </summary>
    public string mime { get; private set; }

    private allimagesWhere()
    {
    }
  }
}
