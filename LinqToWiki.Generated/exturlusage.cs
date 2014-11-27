// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.exturlusageSelect
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki;
using LinqToWiki.Internals;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class exturlusageSelect
  {
    public long pageid { get; private set; }

    public Namespace ns { get; private set; }

    public string title { get; private set; }

    public string url { get; private set; }

    private exturlusageSelect()
    {
    }

    public static exturlusageSelect Parse(XElement element, WikiInfo wiki)
    {
      exturlusageSelect exturlusageSelect = new exturlusageSelect();
      XAttribute xattribute1 = element.Attribute((XName) "pageid");
      if (xattribute1 != null && xattribute1.Value != "")
        exturlusageSelect.pageid = ValueParser.ParseInt64(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "ns");
      if (xattribute2 != null && xattribute2.Value != "")
        exturlusageSelect.ns = ValueParser.ParseNamespace(xattribute2.Value, wiki);
      XAttribute xattribute3 = element.Attribute((XName) "title");
      if (xattribute3 != null)
        exturlusageSelect.title = ValueParser.ParseString(xattribute3.Value);
      XAttribute xattribute4 = element.Attribute((XName) "url");
      if (xattribute4 != null)
        exturlusageSelect.url = ValueParser.ParseString(xattribute4.Value);
      return exturlusageSelect;
    }

    public override string ToString()
    {
      return string.Format("pageid: {0}; ns: {1}; title: {2}; url: {3}", (object) this.pageid, (object) this.ns, (object) this.title, (object) this.url);
    }
  }
}
