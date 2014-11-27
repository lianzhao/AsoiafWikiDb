// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.tagsSelect
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class tagsSelect
  {
    public string name { get; private set; }

    public string displayname { get; private set; }

    public string description { get; private set; }

    public int hitcount { get; private set; }

    private tagsSelect()
    {
    }

    public static tagsSelect Parse(XElement element, WikiInfo wiki)
    {
      tagsSelect tagsSelect = new tagsSelect();
      XAttribute xattribute1 = element.Attribute((XName) "name");
      if (xattribute1 != null)
        tagsSelect.name = ValueParser.ParseString(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "displayname");
      if (xattribute2 != null)
        tagsSelect.displayname = ValueParser.ParseString(xattribute2.Value);
      XAttribute xattribute3 = element.Attribute((XName) "description");
      if (xattribute3 != null)
        tagsSelect.description = ValueParser.ParseString(xattribute3.Value);
      XAttribute xattribute4 = element.Attribute((XName) "hitcount");
      if (xattribute4 != null && xattribute4.Value != "")
        tagsSelect.hitcount = ValueParser.ParseInt32(xattribute4.Value);
      return tagsSelect;
    }

    public override string ToString()
    {
      return string.Format("name: {0}; displayname: {1}; description: {2}; hitcount: {3}", (object) this.name, (object) this.displayname, (object) this.description, (object) this.hitcount);
    }
  }
}
