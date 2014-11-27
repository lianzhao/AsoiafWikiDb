// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.deleteResult
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class deleteResult
  {
    public string title { get; private set; }

    public string reason { get; private set; }

    public long logid { get; private set; }

    private deleteResult()
    {
    }

    public static deleteResult Parse(XElement element, WikiInfo wiki)
    {
      deleteResult deleteResult = new deleteResult();
      XAttribute xattribute1 = element.Attribute((XName) "title");
      if (xattribute1 != null)
        deleteResult.title = ValueParser.ParseString(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "reason");
      if (xattribute2 != null)
        deleteResult.reason = ValueParser.ParseString(xattribute2.Value);
      XAttribute xattribute3 = element.Attribute((XName) "logid");
      if (xattribute3 != null && xattribute3.Value != "")
        deleteResult.logid = ValueParser.ParseInt64(xattribute3.Value);
      return deleteResult;
    }

    public override string ToString()
    {
      return string.Format("title: {0}; reason: {1}; logid: {2}", (object) this.title, (object) this.reason, (object) this.logid);
    }
  }
}
