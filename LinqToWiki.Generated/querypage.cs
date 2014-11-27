// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.querypageSelect
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki;
using LinqToWiki.Internals;
using System;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class querypageSelect
  {
    public string value { get; private set; }

    public DateTime? timestamp { get; private set; }

    public Namespace ns { get; private set; }

    public string title { get; private set; }

    private querypageSelect()
    {
    }

    public static querypageSelect Parse(XElement element, WikiInfo wiki)
    {
      querypageSelect querypageSelect = new querypageSelect();
      XAttribute xattribute1 = element.Attribute((XName) "value");
      if (xattribute1 != null)
        querypageSelect.value = ValueParser.ParseString(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "timestamp");
      if (xattribute2 != null && xattribute2.Value != "")
        querypageSelect.timestamp = new DateTime?(ValueParser.ParseDateTime(xattribute2.Value));
      XAttribute xattribute3 = element.Attribute((XName) "ns");
      if (xattribute3 != null && xattribute3.Value != "")
        querypageSelect.ns = ValueParser.ParseNamespace(xattribute3.Value, wiki);
      XAttribute xattribute4 = element.Attribute((XName) "title");
      if (xattribute4 != null)
        querypageSelect.title = ValueParser.ParseString(xattribute4.Value);
      return querypageSelect;
    }

    public override string ToString()
    {
      return string.Format("value: {0}; timestamp: {1}; ns: {2}; title: {3}", (object) this.value, (object) this.timestamp, (object) this.ns, (object) this.title);
    }
  }
}
