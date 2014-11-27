// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.imageusageSelect
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki;
using LinqToWiki.Internals;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class imageusageSelect
  {
    public long pageid { get; private set; }

    public Namespace ns { get; private set; }

    public string title { get; private set; }

    public bool redirect { get; private set; }

    private imageusageSelect()
    {
    }

    public static imageusageSelect Parse(XElement element, WikiInfo wiki)
    {
      imageusageSelect imageusageSelect = new imageusageSelect();
      XAttribute xattribute1 = element.Attribute((XName) "pageid");
      if (xattribute1 != null && xattribute1.Value != "")
        imageusageSelect.pageid = ValueParser.ParseInt64(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "ns");
      if (xattribute2 != null && xattribute2.Value != "")
        imageusageSelect.ns = ValueParser.ParseNamespace(xattribute2.Value, wiki);
      XAttribute xattribute3 = element.Attribute((XName) "title");
      if (xattribute3 != null)
        imageusageSelect.title = ValueParser.ParseString(xattribute3.Value);
      XAttribute xattribute4 = element.Attribute((XName) "redirect");
      if (xattribute4 != null)
        imageusageSelect.redirect = ValueParser.ParseBoolean(xattribute4.Value);
      return imageusageSelect;
    }

    public override string ToString()
    {
      return string.Format("pageid: {0}; ns: {1}; title: {2}; redirect: {3}", (object) this.pageid, (object) this.ns, (object) this.title, (this.redirect ? 1 : 0));
    }
  }
}
