// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.patrolResult
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki;
using LinqToWiki.Internals;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class patrolResult
  {
    public long rcid { get; private set; }

    public Namespace ns { get; private set; }

    public string title { get; private set; }

    private patrolResult()
    {
    }

    public static patrolResult Parse(XElement element, WikiInfo wiki)
    {
      patrolResult patrolResult = new patrolResult();
      XAttribute xattribute1 = element.Attribute((XName) "rcid");
      if (xattribute1 != null && xattribute1.Value != "")
        patrolResult.rcid = ValueParser.ParseInt64(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "ns");
      if (xattribute2 != null && xattribute2.Value != "")
        patrolResult.ns = ValueParser.ParseNamespace(xattribute2.Value, wiki);
      XAttribute xattribute3 = element.Attribute((XName) "title");
      if (xattribute3 != null)
        patrolResult.title = ValueParser.ParseString(xattribute3.Value);
      return patrolResult;
    }

    public override string ToString()
    {
      return string.Format("rcid: {0}; ns: {1}; title: {2}", (object) this.rcid, (object) this.ns, (object) this.title);
    }
  }
}
