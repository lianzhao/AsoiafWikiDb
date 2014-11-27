// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.extlinksSelect
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class extlinksSelect
  {
    public string value { get; private set; }

    private extlinksSelect()
    {
    }

    public static extlinksSelect Parse(XElement element, WikiInfo wiki)
    {
      extlinksSelect extlinksSelect = new extlinksSelect();
      XElement xelement = element;
      extlinksSelect.value = ValueParser.ParseString(xelement.Value);
      return extlinksSelect;
    }

    public override string ToString()
    {
      return string.Format("value: {0}", (object) this.value);
    }
  }
}
