// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.duplicatefilesSelect
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;
using System;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class duplicatefilesSelect
  {
    public string name { get; private set; }

    public string user { get; private set; }

    public DateTime timestamp { get; private set; }

    public bool shared { get; private set; }

    private duplicatefilesSelect()
    {
    }

    public static duplicatefilesSelect Parse(XElement element, WikiInfo wiki)
    {
      duplicatefilesSelect duplicatefilesSelect = new duplicatefilesSelect();
      XAttribute xattribute1 = element.Attribute((XName) "name");
      if (xattribute1 != null)
        duplicatefilesSelect.name = ValueParser.ParseString(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "user");
      if (xattribute2 != null)
        duplicatefilesSelect.user = ValueParser.ParseString(xattribute2.Value);
      XAttribute xattribute3 = element.Attribute((XName) "timestamp");
      if (xattribute3 != null && xattribute3.Value != "")
        duplicatefilesSelect.timestamp = ValueParser.ParseDateTime(xattribute3.Value);
      XAttribute xattribute4 = element.Attribute((XName) "shared");
      if (xattribute4 != null)
        duplicatefilesSelect.shared = ValueParser.ParseBoolean(xattribute4.Value);
      return duplicatefilesSelect;
    }

    public override string ToString()
    {
      return string.Format("name: {0}; user: {1}; timestamp: {2}; shared: {3}", (object) this.name, (object) this.user, (object) this.timestamp, (object) (bool) (this.shared ? 1 : 0));
    }
  }
}
