// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.blocksSelect
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;
using System;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class blocksSelect
  {
    public long id { get; private set; }

    public string user { get; private set; }

    public long? userid { get; private set; }

    public string by { get; private set; }

    public long byid { get; private set; }

    public DateTime timestamp { get; private set; }

    public DateTime expiry { get; private set; }

    public string reason { get; private set; }

    public string rangestart { get; private set; }

    public string rangeend { get; private set; }

    public bool automatic { get; private set; }

    public bool anononly { get; private set; }

    public bool nocreate { get; private set; }

    public bool autoblock { get; private set; }

    public bool noemail { get; private set; }

    public bool hidden { get; private set; }

    public bool allowusertalk { get; private set; }

    private blocksSelect()
    {
    }

    public static blocksSelect Parse(XElement element, WikiInfo wiki)
    {
      blocksSelect blocksSelect = new blocksSelect();
      XAttribute xattribute1 = element.Attribute((XName) "id");
      if (xattribute1 != null && xattribute1.Value != "")
        blocksSelect.id = ValueParser.ParseInt64(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "user");
      if (xattribute2 != null)
        blocksSelect.user = ValueParser.ParseString(xattribute2.Value);
      XAttribute xattribute3 = element.Attribute((XName) "userid");
      if (xattribute3 != null && xattribute3.Value != "")
        blocksSelect.userid = new long?(ValueParser.ParseInt64(xattribute3.Value));
      XAttribute xattribute4 = element.Attribute((XName) "by");
      if (xattribute4 != null)
        blocksSelect.by = ValueParser.ParseString(xattribute4.Value);
      XAttribute xattribute5 = element.Attribute((XName) "byid");
      if (xattribute5 != null && xattribute5.Value != "")
        blocksSelect.byid = ValueParser.ParseInt64(xattribute5.Value);
      XAttribute xattribute6 = element.Attribute((XName) "timestamp");
      if (xattribute6 != null && xattribute6.Value != "")
        blocksSelect.timestamp = ValueParser.ParseDateTime(xattribute6.Value);
      XAttribute xattribute7 = element.Attribute((XName) "expiry");
      if (xattribute7 != null && xattribute7.Value != "")
        blocksSelect.expiry = ValueParser.ParseDateTime(xattribute7.Value);
      XAttribute xattribute8 = element.Attribute((XName) "reason");
      if (xattribute8 != null)
        blocksSelect.reason = ValueParser.ParseString(xattribute8.Value);
      XAttribute xattribute9 = element.Attribute((XName) "rangestart");
      if (xattribute9 != null)
        blocksSelect.rangestart = ValueParser.ParseString(xattribute9.Value);
      XAttribute xattribute10 = element.Attribute((XName) "rangeend");
      if (xattribute10 != null)
        blocksSelect.rangeend = ValueParser.ParseString(xattribute10.Value);
      XAttribute xattribute11 = element.Attribute((XName) "automatic");
      if (xattribute11 != null)
        blocksSelect.automatic = ValueParser.ParseBoolean(xattribute11.Value);
      XAttribute xattribute12 = element.Attribute((XName) "anononly");
      if (xattribute12 != null)
        blocksSelect.anononly = ValueParser.ParseBoolean(xattribute12.Value);
      XAttribute xattribute13 = element.Attribute((XName) "nocreate");
      if (xattribute13 != null)
        blocksSelect.nocreate = ValueParser.ParseBoolean(xattribute13.Value);
      XAttribute xattribute14 = element.Attribute((XName) "autoblock");
      if (xattribute14 != null)
        blocksSelect.autoblock = ValueParser.ParseBoolean(xattribute14.Value);
      XAttribute xattribute15 = element.Attribute((XName) "noemail");
      if (xattribute15 != null)
        blocksSelect.noemail = ValueParser.ParseBoolean(xattribute15.Value);
      XAttribute xattribute16 = element.Attribute((XName) "hidden");
      if (xattribute16 != null)
        blocksSelect.hidden = ValueParser.ParseBoolean(xattribute16.Value);
      XAttribute xattribute17 = element.Attribute((XName) "allowusertalk");
      if (xattribute17 != null)
        blocksSelect.allowusertalk = ValueParser.ParseBoolean(xattribute17.Value);
      return blocksSelect;
    }

    public override string ToString()
    {
      return string.Format("id: {0}; user: {1}; userid: {2}; by: {3}; byid: {4}; timestamp: {5}; expiry: {6}; reason: {7}; rangestart: {8}; rangeend: {9}; automatic: {10}; anononly: {11}; nocreate: {12}; autoblock: {13}; noemail: {14}; hidden: {15}; allowusertalk: {16}", (object) this.id, (object) this.user, (object) this.userid, (object) this.by, (object) this.byid, (object) this.timestamp, (object) this.expiry, (object) this.reason, (object) this.rangestart, (object) this.rangeend, (this.automatic ? 1 : 0), (this.anononly ? 1 : 0), (this.nocreate ? 1 : 0), (this.autoblock ? 1 : 0), (this.noemail ? 1 : 0), (this.hidden ? 1 : 0), (this.allowusertalk ? 1 : 0));
    }
  }
}
