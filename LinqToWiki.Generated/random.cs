﻿// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.randomSelect
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki;
using LinqToWiki.Internals;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class randomSelect
  {
    public long id { get; private set; }

    public Namespace ns { get; private set; }

    public string title { get; private set; }

    private randomSelect()
    {
    }

    public static randomSelect Parse(XElement element, WikiInfo wiki)
    {
      randomSelect randomSelect = new randomSelect();
      XAttribute xattribute1 = element.Attribute((XName) "id");
      if (xattribute1 != null && xattribute1.Value != "")
        randomSelect.id = ValueParser.ParseInt64(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "ns");
      if (xattribute2 != null && xattribute2.Value != "")
        randomSelect.ns = ValueParser.ParseNamespace(xattribute2.Value, wiki);
      XAttribute xattribute3 = element.Attribute((XName) "title");
      if (xattribute3 != null)
        randomSelect.title = ValueParser.ParseString(xattribute3.Value);
      return randomSelect;
    }

    public override string ToString()
    {
      return string.Format("id: {0}; ns: {1}; title: {2}", (object) this.id, (object) this.ns, (object) this.title);
    }
  }
}
