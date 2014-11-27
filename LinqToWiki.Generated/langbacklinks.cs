// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.langbacklinksSelect
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki;
using LinqToWiki.Internals;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class langbacklinksSelect
  {
    public long pageid { get; private set; }

    public Namespace ns { get; private set; }

    public string title { get; private set; }

    public bool redirect { get; private set; }

    public string lllang { get; private set; }

    public string lltitle { get; private set; }

    private langbacklinksSelect()
    {
    }

    public static langbacklinksSelect Parse(XElement element, WikiInfo wiki)
    {
      langbacklinksSelect langbacklinksSelect = new langbacklinksSelect();
      XAttribute xattribute1 = element.Attribute((XName) "pageid");
      if (xattribute1 != null && xattribute1.Value != "")
        langbacklinksSelect.pageid = ValueParser.ParseInt64(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "ns");
      if (xattribute2 != null && xattribute2.Value != "")
        langbacklinksSelect.ns = ValueParser.ParseNamespace(xattribute2.Value, wiki);
      XAttribute xattribute3 = element.Attribute((XName) "title");
      if (xattribute3 != null)
        langbacklinksSelect.title = ValueParser.ParseString(xattribute3.Value);
      XAttribute xattribute4 = element.Attribute((XName) "redirect");
      if (xattribute4 != null)
        langbacklinksSelect.redirect = ValueParser.ParseBoolean(xattribute4.Value);
      XAttribute xattribute5 = element.Attribute((XName) "lllang");
      if (xattribute5 != null)
        langbacklinksSelect.lllang = ValueParser.ParseString(xattribute5.Value);
      XAttribute xattribute6 = element.Attribute((XName) "lltitle");
      if (xattribute6 != null)
        langbacklinksSelect.lltitle = ValueParser.ParseString(xattribute6.Value);
      return langbacklinksSelect;
    }

    public override string ToString()
    {
      return string.Format("pageid: {0}; ns: {1}; title: {2}; redirect: {3}; lllang: {4}; lltitle: {5}", (object) this.pageid, (object) this.ns, (object) this.title, (this.redirect ? 1 : 0), (object) this.lllang, (object) this.lltitle);
    }
  }
}
