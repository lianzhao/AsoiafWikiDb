﻿// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.templatesSelect
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki;
using LinqToWiki.Internals;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class templatesSelect
  {
    public Namespace ns { get; private set; }

    public string title { get; private set; }

    private templatesSelect()
    {
    }

    public static templatesSelect Parse(XElement element, WikiInfo wiki)
    {
      templatesSelect templatesSelect = new templatesSelect();
      XAttribute xattribute1 = element.Attribute((XName) "ns");
      if (xattribute1 != null && xattribute1.Value != "")
        templatesSelect.ns = ValueParser.ParseNamespace(xattribute1.Value, wiki);
      XAttribute xattribute2 = element.Attribute((XName) "title");
      if (xattribute2 != null)
        templatesSelect.title = ValueParser.ParseString(xattribute2.Value);
      return templatesSelect;
    }

    public override string ToString()
    {
      return string.Format("ns: {0}; title: {1}", (object) this.ns, (object) this.title);
    }
  }
}
