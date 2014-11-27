// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.categorymembersSelect
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki;
using LinqToWiki.Generated;
using LinqToWiki.Internals;
using System;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class categorymembersSelect
  {
    public long pageid { get; private set; }

    public Namespace ns { get; private set; }

    public string title { get; private set; }

    public string sortkey { get; private set; }

    public string sortkeyprefix { get; private set; }

    public categorymemberstype type { get; private set; }

    public DateTime timestamp { get; private set; }

    private categorymembersSelect()
    {
    }

    public static categorymembersSelect Parse(XElement element, WikiInfo wiki)
    {
      categorymembersSelect categorymembersSelect = new categorymembersSelect();
      XAttribute xattribute1 = element.Attribute((XName) "pageid");
      if (xattribute1 != null && xattribute1.Value != "")
        categorymembersSelect.pageid = ValueParser.ParseInt64(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "ns");
      if (xattribute2 != null && xattribute2.Value != "")
        categorymembersSelect.ns = ValueParser.ParseNamespace(xattribute2.Value, wiki);
      XAttribute xattribute3 = element.Attribute((XName) "title");
      if (xattribute3 != null)
        categorymembersSelect.title = ValueParser.ParseString(xattribute3.Value);
      XAttribute xattribute4 = element.Attribute((XName) "sortkey");
      if (xattribute4 != null)
        categorymembersSelect.sortkey = ValueParser.ParseString(xattribute4.Value);
      XAttribute xattribute5 = element.Attribute((XName) "sortkeyprefix");
      if (xattribute5 != null)
        categorymembersSelect.sortkeyprefix = ValueParser.ParseString(xattribute5.Value);
      XAttribute xattribute6 = element.Attribute((XName) "type");
      if (xattribute6 != null && xattribute6.Value != "")
        categorymembersSelect.type = new categorymemberstype(xattribute6.Value);
      XAttribute xattribute7 = element.Attribute((XName) "timestamp");
      if (xattribute7 != null && xattribute7.Value != "")
        categorymembersSelect.timestamp = ValueParser.ParseDateTime(xattribute7.Value);
      return categorymembersSelect;
    }

    public override string ToString()
    {
      return string.Format("pageid: {0}; ns: {1}; title: {2}; sortkey: {3}; sortkeyprefix: {4}; type: {5}; timestamp: {6}", (object) this.pageid, (object) this.ns, (object) this.title, (object) this.sortkey, (object) this.sortkeyprefix, (object) this.type, (object) this.timestamp);
    }
  }
}
