// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.protectResult
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class protectResult
  {
    public string title { get; private set; }

    public string reason { get; private set; }

    public bool cascade { get; private set; }

    private protectResult()
    {
    }

    public static protectResult Parse(XElement element, WikiInfo wiki)
    {
      protectResult protectResult = new protectResult();
      XAttribute xattribute1 = element.Attribute((XName) "title");
      if (xattribute1 != null)
        protectResult.title = ValueParser.ParseString(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "reason");
      if (xattribute2 != null)
        protectResult.reason = ValueParser.ParseString(xattribute2.Value);
      XAttribute xattribute3 = element.Attribute((XName) "cascade");
      if (xattribute3 != null)
        protectResult.cascade = ValueParser.ParseBoolean(xattribute3.Value);
      return protectResult;
    }

    public override string ToString()
    {
      return string.Format("title: {0}; reason: {1}; cascade: {2}", (object) this.title, (object) this.reason, (this.cascade ? 1 : 0));
    }
  }
}
