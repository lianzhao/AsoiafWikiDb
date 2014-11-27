// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.importResult
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki;
using LinqToWiki.Internals;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class importResult
  {
    public Namespace ns { get; private set; }

    public string title { get; private set; }

    public int revisions { get; private set; }

    private importResult()
    {
    }

    public static importResult Parse(XElement element, WikiInfo wiki)
    {
      importResult importResult = new importResult();
      XAttribute xattribute1 = element.Attribute((XName) "ns");
      if (xattribute1 != null && xattribute1.Value != "")
        importResult.ns = ValueParser.ParseNamespace(xattribute1.Value, wiki);
      XAttribute xattribute2 = element.Attribute((XName) "title");
      if (xattribute2 != null)
        importResult.title = ValueParser.ParseString(xattribute2.Value);
      XAttribute xattribute3 = element.Attribute((XName) "revisions");
      if (xattribute3 != null && xattribute3.Value != "")
        importResult.revisions = ValueParser.ParseInt32(xattribute3.Value);
      return importResult;
    }

    public override string ToString()
    {
      return string.Format("ns: {0}; title: {1}; revisions: {2}", (object) this.ns, (object) this.title, (object) this.revisions);
    }
  }
}
