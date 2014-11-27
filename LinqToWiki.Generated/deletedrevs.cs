// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.deletedrevsSelect
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki;
using LinqToWiki.Internals;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class deletedrevsSelect
  {
    public Namespace ns { get; private set; }

    public string title { get; private set; }

    public string token { get; private set; }

    private deletedrevsSelect()
    {
    }

    public static deletedrevsSelect Parse(XElement element, WikiInfo wiki)
    {
      deletedrevsSelect deletedrevsSelect = new deletedrevsSelect();
      XAttribute xattribute1 = element.Attribute((XName) "ns");
      if (xattribute1 != null && xattribute1.Value != "")
        deletedrevsSelect.ns = ValueParser.ParseNamespace(xattribute1.Value, wiki);
      XAttribute xattribute2 = element.Attribute((XName) "title");
      if (xattribute2 != null)
        deletedrevsSelect.title = ValueParser.ParseString(xattribute2.Value);
      XAttribute xattribute3 = element.Attribute((XName) "token");
      if (xattribute3 != null)
        deletedrevsSelect.token = ValueParser.ParseString(xattribute3.Value);
      return deletedrevsSelect;
    }

    public override string ToString()
    {
      return string.Format("ns: {0}; title: {1}; token: {2}", (object) this.ns, (object) this.title, (object) this.token);
    }
  }
}
