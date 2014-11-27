// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.categoriesSelect
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki;
using LinqToWiki.Internals;
using System;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class categoriesSelect
  {
    public Namespace ns { get; private set; }

    public string title { get; private set; }

    public string sortkey { get; private set; }

    public string sortkeyprefix { get; private set; }

    public DateTime timestamp { get; private set; }

    public bool hidden { get; private set; }

    private categoriesSelect()
    {
    }

    public static categoriesSelect Parse(XElement element, WikiInfo wiki)
    {
      categoriesSelect categoriesSelect = new categoriesSelect();
      XAttribute xattribute1 = element.Attribute((XName) "ns");
      if (xattribute1 != null && xattribute1.Value != "")
        categoriesSelect.ns = ValueParser.ParseNamespace(xattribute1.Value, wiki);
      XAttribute xattribute2 = element.Attribute((XName) "title");
      if (xattribute2 != null)
        categoriesSelect.title = ValueParser.ParseString(xattribute2.Value);
      XAttribute xattribute3 = element.Attribute((XName) "sortkey");
      if (xattribute3 != null)
        categoriesSelect.sortkey = ValueParser.ParseString(xattribute3.Value);
      XAttribute xattribute4 = element.Attribute((XName) "sortkeyprefix");
      if (xattribute4 != null)
        categoriesSelect.sortkeyprefix = ValueParser.ParseString(xattribute4.Value);
      XAttribute xattribute5 = element.Attribute((XName) "timestamp");
      if (xattribute5 != null && xattribute5.Value != "")
        categoriesSelect.timestamp = ValueParser.ParseDateTime(xattribute5.Value);
      XAttribute xattribute6 = element.Attribute((XName) "hidden");
      if (xattribute6 != null)
        categoriesSelect.hidden = ValueParser.ParseBoolean(xattribute6.Value);
      return categoriesSelect;
    }

    public override string ToString()
    {
      return string.Format("ns: {0}; title: {1}; sortkey: {2}; sortkeyprefix: {3}; timestamp: {4}; hidden: {5}", (object) this.ns, (object) this.title, (object) this.sortkey, (object) this.sortkeyprefix, (object) this.timestamp, (object) (bool) (this.hidden ? 1 : 0));
    }
  }
}
