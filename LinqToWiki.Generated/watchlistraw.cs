// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.watchlistrawSelect
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki;
using LinqToWiki.Internals;
using System;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class watchlistrawSelect
  {
    public Namespace ns { get; private set; }

    public string title { get; private set; }

    public DateTime? changed { get; private set; }

    private watchlistrawSelect()
    {
    }

    public static watchlistrawSelect Parse(XElement element, WikiInfo wiki)
    {
      watchlistrawSelect watchlistrawSelect = new watchlistrawSelect();
      XAttribute xattribute1 = element.Attribute((XName) "ns");
      if (xattribute1 != null && xattribute1.Value != "")
        watchlistrawSelect.ns = ValueParser.ParseNamespace(xattribute1.Value, wiki);
      XAttribute xattribute2 = element.Attribute((XName) "title");
      if (xattribute2 != null)
        watchlistrawSelect.title = ValueParser.ParseString(xattribute2.Value);
      XAttribute xattribute3 = element.Attribute((XName) "changed");
      if (xattribute3 != null && xattribute3.Value != "")
        watchlistrawSelect.changed = new DateTime?(ValueParser.ParseDateTime(xattribute3.Value));
      return watchlistrawSelect;
    }

    public override string ToString()
    {
      return string.Format("ns: {0}; title: {1}; changed: {2}", (object) this.ns, (object) this.title, (object) this.changed);
    }
  }
}
