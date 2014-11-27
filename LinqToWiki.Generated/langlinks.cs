// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.langlinksSelect
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class langlinksSelect
  {
    public string lang { get; private set; }

    public string url { get; private set; }

    public string value { get; private set; }

    private langlinksSelect()
    {
    }

    public static langlinksSelect Parse(XElement element, WikiInfo wiki)
    {
      langlinksSelect langlinksSelect = new langlinksSelect();
      XAttribute xattribute1 = element.Attribute((XName) "lang");
      if (xattribute1 != null)
        langlinksSelect.lang = ValueParser.ParseString(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "url");
      if (xattribute2 != null)
        langlinksSelect.url = ValueParser.ParseString(xattribute2.Value);
      XElement xelement = element;
      langlinksSelect.value = ValueParser.ParseString(xelement.Value);
      return langlinksSelect;
    }

    public override string ToString()
    {
      return string.Format("lang: {0}; url: {1}; value: {2}", (object) this.lang, (object) this.url, (object) this.value);
    }
  }
}
