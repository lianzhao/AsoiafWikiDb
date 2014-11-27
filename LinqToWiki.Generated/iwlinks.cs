// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.iwlinksSelect
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class iwlinksSelect
  {
    public string prefix { get; private set; }

    public string url { get; private set; }

    public string value { get; private set; }

    private iwlinksSelect()
    {
    }

    public static iwlinksSelect Parse(XElement element, WikiInfo wiki)
    {
      iwlinksSelect iwlinksSelect = new iwlinksSelect();
      XAttribute xattribute1 = element.Attribute((XName) "prefix");
      if (xattribute1 != null)
        iwlinksSelect.prefix = ValueParser.ParseString(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "url");
      if (xattribute2 != null)
        iwlinksSelect.url = ValueParser.ParseString(xattribute2.Value);
      XElement xelement = element;
      iwlinksSelect.value = ValueParser.ParseString(xelement.Value);
      return iwlinksSelect;
    }

    public override string ToString()
    {
      return string.Format("prefix: {0}; url: {1}; value: {2}", (object) this.prefix, (object) this.url, (object) this.value);
    }
  }
}
