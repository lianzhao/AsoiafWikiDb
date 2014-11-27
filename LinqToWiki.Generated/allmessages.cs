// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.allmessagesSelect
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class allmessagesSelect
  {
    public string name { get; private set; }

    public bool customised { get; private set; }

    public bool missing { get; private set; }

    public string value { get; private set; }

    public bool defaultmissing { get; private set; }

    public string defaultvalue { get; private set; }

    private allmessagesSelect()
    {
    }

    public static allmessagesSelect Parse(XElement element, WikiInfo wiki)
    {
      allmessagesSelect allmessagesSelect = new allmessagesSelect();
      XAttribute xattribute1 = element.Attribute((XName) "name");
      if (xattribute1 != null)
        allmessagesSelect.name = ValueParser.ParseString(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "customised");
      if (xattribute2 != null)
        allmessagesSelect.customised = ValueParser.ParseBoolean(xattribute2.Value);
      XAttribute xattribute3 = element.Attribute((XName) "missing");
      if (xattribute3 != null)
        allmessagesSelect.missing = ValueParser.ParseBoolean(xattribute3.Value);
      XElement xelement = element;
      allmessagesSelect.value = ValueParser.ParseString(xelement.Value);
      XAttribute xattribute4 = element.Attribute((XName) "defaultmissing");
      if (xattribute4 != null)
        allmessagesSelect.defaultmissing = ValueParser.ParseBoolean(xattribute4.Value);
      XAttribute xattribute5 = element.Attribute((XName) "default");
      if (xattribute5 != null)
        allmessagesSelect.defaultvalue = ValueParser.ParseString(xattribute5.Value);
      return allmessagesSelect;
    }

    public override string ToString()
    {
      return string.Format("name: {0}; customised: {1}; missing: {2}; value: {3}; defaultmissing: {4}; defaultvalue: {5}", (object) this.name, (this.customised ? 1 : 0), (this.missing ? 1 : 0), (object) this.value, (this.defaultmissing ? 1 : 0), (object) this.defaultvalue);
    }
  }
}
