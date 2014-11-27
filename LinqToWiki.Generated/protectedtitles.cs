// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.protectedtitlesSelect
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki;
using LinqToWiki.Generated;
using LinqToWiki.Internals;
using System;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class protectedtitlesSelect
  {
    public Namespace ns { get; private set; }

    public string title { get; private set; }

    public DateTime timestamp { get; private set; }

    public string user { get; private set; }

    public long userid { get; private set; }

    public string comment { get; private set; }

    public string parsedcomment { get; private set; }

    public DateTime expiry { get; private set; }

    public protectedtitleslevel level { get; private set; }

    private protectedtitlesSelect()
    {
    }

    public static protectedtitlesSelect Parse(XElement element, WikiInfo wiki)
    {
      protectedtitlesSelect protectedtitlesSelect = new protectedtitlesSelect();
      XAttribute xattribute1 = element.Attribute((XName) "ns");
      if (xattribute1 != null && xattribute1.Value != "")
        protectedtitlesSelect.ns = ValueParser.ParseNamespace(xattribute1.Value, wiki);
      XAttribute xattribute2 = element.Attribute((XName) "title");
      if (xattribute2 != null)
        protectedtitlesSelect.title = ValueParser.ParseString(xattribute2.Value);
      XAttribute xattribute3 = element.Attribute((XName) "timestamp");
      if (xattribute3 != null && xattribute3.Value != "")
        protectedtitlesSelect.timestamp = ValueParser.ParseDateTime(xattribute3.Value);
      XAttribute xattribute4 = element.Attribute((XName) "user");
      if (xattribute4 != null)
        protectedtitlesSelect.user = ValueParser.ParseString(xattribute4.Value);
      XAttribute xattribute5 = element.Attribute((XName) "userid");
      if (xattribute5 != null && xattribute5.Value != "")
        protectedtitlesSelect.userid = ValueParser.ParseInt64(xattribute5.Value);
      XAttribute xattribute6 = element.Attribute((XName) "comment");
      if (xattribute6 != null)
        protectedtitlesSelect.comment = ValueParser.ParseString(xattribute6.Value);
      XAttribute xattribute7 = element.Attribute((XName) "parsedcomment");
      if (xattribute7 != null)
        protectedtitlesSelect.parsedcomment = ValueParser.ParseString(xattribute7.Value);
      XAttribute xattribute8 = element.Attribute((XName) "expiry");
      if (xattribute8 != null && xattribute8.Value != "")
        protectedtitlesSelect.expiry = ValueParser.ParseDateTime(xattribute8.Value);
      XAttribute xattribute9 = element.Attribute((XName) "level");
      if (xattribute9 != null && xattribute9.Value != "")
        protectedtitlesSelect.level = new protectedtitleslevel(xattribute9.Value);
      return protectedtitlesSelect;
    }

    public override string ToString()
    {
      return string.Format("ns: {0}; title: {1}; timestamp: {2}; user: {3}; userid: {4}; comment: {5}; parsedcomment: {6}; expiry: {7}; level: {8}", (object) this.ns, (object) this.title, (object) this.timestamp, (object) this.user, (object) this.userid, (object) this.comment, (object) this.parsedcomment, (object) this.expiry, (object) this.level);
    }
  }
}
