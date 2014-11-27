// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.setnotificationtimestampResult
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki;
using LinqToWiki.Internals;
using System;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class setnotificationtimestampResult
  {
    public Namespace ns { get; private set; }

    public string title { get; private set; }

    public long? pageid { get; private set; }

    public long? revid { get; private set; }

    public bool invalid { get; private set; }

    public bool missing { get; private set; }

    public bool notwatched { get; private set; }

    public DateTime? notificationtimestamp { get; private set; }

    private setnotificationtimestampResult()
    {
    }

    public static setnotificationtimestampResult Parse(XElement element, WikiInfo wiki)
    {
      setnotificationtimestampResult setnotificationtimestampResult = new setnotificationtimestampResult();
      XAttribute xattribute1 = element.Attribute((XName) "ns");
      if (xattribute1 != null && xattribute1.Value != "")
        setnotificationtimestampResult.ns = ValueParser.ParseNamespace(xattribute1.Value, wiki);
      XAttribute xattribute2 = element.Attribute((XName) "title");
      if (xattribute2 != null)
        setnotificationtimestampResult.title = ValueParser.ParseString(xattribute2.Value);
      XAttribute xattribute3 = element.Attribute((XName) "pageid");
      if (xattribute3 != null && xattribute3.Value != "")
        setnotificationtimestampResult.pageid = new long?(ValueParser.ParseInt64(xattribute3.Value));
      XAttribute xattribute4 = element.Attribute((XName) "revid");
      if (xattribute4 != null && xattribute4.Value != "")
        setnotificationtimestampResult.revid = new long?(ValueParser.ParseInt64(xattribute4.Value));
      XAttribute xattribute5 = element.Attribute((XName) "invalid");
      if (xattribute5 != null)
        setnotificationtimestampResult.invalid = ValueParser.ParseBoolean(xattribute5.Value);
      XAttribute xattribute6 = element.Attribute((XName) "missing");
      if (xattribute6 != null)
        setnotificationtimestampResult.missing = ValueParser.ParseBoolean(xattribute6.Value);
      XAttribute xattribute7 = element.Attribute((XName) "notwatched");
      if (xattribute7 != null)
        setnotificationtimestampResult.notwatched = ValueParser.ParseBoolean(xattribute7.Value);
      XAttribute xattribute8 = element.Attribute((XName) "notificationtimestamp");
      if (xattribute8 != null && xattribute8.Value != "")
        setnotificationtimestampResult.notificationtimestamp = new DateTime?(ValueParser.ParseDateTime(xattribute8.Value));
      return setnotificationtimestampResult;
    }

    public override string ToString()
    {
      return string.Format("ns: {0}; title: {1}; pageid: {2}; revid: {3}; invalid: {4}; missing: {5}; notwatched: {6}; notificationtimestamp: {7}", (object) this.ns, (object) this.title, (object) this.pageid, (object) this.revid, (this.invalid ? 1 : 0), (this.missing ? 1 : 0), (this.notwatched ? 1 : 0), (object) this.notificationtimestamp);
    }
  }
}
