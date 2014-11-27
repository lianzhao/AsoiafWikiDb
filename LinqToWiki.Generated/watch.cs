// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.watchResult
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class watchResult
  {
    public string title { get; private set; }

    public bool unwatched { get; private set; }

    public bool watched { get; private set; }

    public string message { get; private set; }

    private watchResult()
    {
    }

    public static watchResult Parse(XElement element, WikiInfo wiki)
    {
      watchResult watchResult = new watchResult();
      XAttribute xattribute1 = element.Attribute((XName) "title");
      if (xattribute1 != null)
        watchResult.title = ValueParser.ParseString(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "unwatched");
      if (xattribute2 != null)
        watchResult.unwatched = ValueParser.ParseBoolean(xattribute2.Value);
      XAttribute xattribute3 = element.Attribute((XName) "watched");
      if (xattribute3 != null)
        watchResult.watched = ValueParser.ParseBoolean(xattribute3.Value);
      XAttribute xattribute4 = element.Attribute((XName) "message");
      if (xattribute4 != null)
        watchResult.message = ValueParser.ParseString(xattribute4.Value);
      return watchResult;
    }

    public override string ToString()
    {
      return string.Format("title: {0}; unwatched: {1}; watched: {2}; message: {3}", (object) this.title, (object) (bool) (this.unwatched ? 1 : 0), (object) (bool) (this.watched ? 1 : 0), (object) this.message);
    }
  }
}
