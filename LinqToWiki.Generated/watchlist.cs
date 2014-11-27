// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.watchlistSelect
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
  public sealed class watchlistSelect
  {
    public watchlisttype type { get; private set; }

    public long pageid { get; private set; }

    public long revid { get; private set; }

    public long old_revid { get; private set; }

    public Namespace ns { get; private set; }

    public string title { get; private set; }

    public string user { get; private set; }

    public bool anon { get; private set; }

    public long userid { get; private set; }

    public bool @new { get; private set; }

    public bool minor { get; private set; }

    public bool bot { get; private set; }

    public bool patrolled { get; private set; }

    public DateTime timestamp { get; private set; }

    public int oldlen { get; private set; }

    public int newlen { get; private set; }

    public DateTime? notificationtimestamp { get; private set; }

    public string comment { get; private set; }

    public string parsedcomment { get; private set; }

    public long? logid { get; private set; }

    public watchlistlogtype logtype { get; private set; }

    public string logaction { get; private set; }

    private watchlistSelect()
    {
    }

    public static watchlistSelect Parse(XElement element, WikiInfo wiki)
    {
      watchlistSelect watchlistSelect = new watchlistSelect();
      XAttribute xattribute1 = element.Attribute((XName) "type");
      if (xattribute1 != null && xattribute1.Value != "")
        watchlistSelect.type = new watchlisttype(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "pageid");
      if (xattribute2 != null && xattribute2.Value != "")
        watchlistSelect.pageid = ValueParser.ParseInt64(xattribute2.Value);
      XAttribute xattribute3 = element.Attribute((XName) "revid");
      if (xattribute3 != null && xattribute3.Value != "")
        watchlistSelect.revid = ValueParser.ParseInt64(xattribute3.Value);
      XAttribute xattribute4 = element.Attribute((XName) "old_revid");
      if (xattribute4 != null && xattribute4.Value != "")
        watchlistSelect.old_revid = ValueParser.ParseInt64(xattribute4.Value);
      XAttribute xattribute5 = element.Attribute((XName) "ns");
      if (xattribute5 != null && xattribute5.Value != "")
        watchlistSelect.ns = ValueParser.ParseNamespace(xattribute5.Value, wiki);
      XAttribute xattribute6 = element.Attribute((XName) "title");
      if (xattribute6 != null)
        watchlistSelect.title = ValueParser.ParseString(xattribute6.Value);
      XAttribute xattribute7 = element.Attribute((XName) "user");
      if (xattribute7 != null)
        watchlistSelect.user = ValueParser.ParseString(xattribute7.Value);
      XAttribute xattribute8 = element.Attribute((XName) "anon");
      if (xattribute8 != null)
        watchlistSelect.anon = ValueParser.ParseBoolean(xattribute8.Value);
      XAttribute xattribute9 = element.Attribute((XName) "userid");
      if (xattribute9 != null && xattribute9.Value != "")
        watchlistSelect.userid = ValueParser.ParseInt64(xattribute9.Value);
      XAttribute xattribute10 = element.Attribute((XName) "new");
      if (xattribute10 != null)
        watchlistSelect.@new = ValueParser.ParseBoolean(xattribute10.Value);
      XAttribute xattribute11 = element.Attribute((XName) "minor");
      if (xattribute11 != null)
        watchlistSelect.minor = ValueParser.ParseBoolean(xattribute11.Value);
      XAttribute xattribute12 = element.Attribute((XName) "bot");
      if (xattribute12 != null)
        watchlistSelect.bot = ValueParser.ParseBoolean(xattribute12.Value);
      XAttribute xattribute13 = element.Attribute((XName) "patrolled");
      if (xattribute13 != null)
        watchlistSelect.patrolled = ValueParser.ParseBoolean(xattribute13.Value);
      XAttribute xattribute14 = element.Attribute((XName) "timestamp");
      if (xattribute14 != null && xattribute14.Value != "")
        watchlistSelect.timestamp = ValueParser.ParseDateTime(xattribute14.Value);
      XAttribute xattribute15 = element.Attribute((XName) "oldlen");
      if (xattribute15 != null && xattribute15.Value != "")
        watchlistSelect.oldlen = ValueParser.ParseInt32(xattribute15.Value);
      XAttribute xattribute16 = element.Attribute((XName) "newlen");
      if (xattribute16 != null && xattribute16.Value != "")
        watchlistSelect.newlen = ValueParser.ParseInt32(xattribute16.Value);
      XAttribute xattribute17 = element.Attribute((XName) "notificationtimestamp");
      if (xattribute17 != null && xattribute17.Value != "")
        watchlistSelect.notificationtimestamp = new DateTime?(ValueParser.ParseDateTime(xattribute17.Value));
      XAttribute xattribute18 = element.Attribute((XName) "comment");
      if (xattribute18 != null)
        watchlistSelect.comment = ValueParser.ParseString(xattribute18.Value);
      XAttribute xattribute19 = element.Attribute((XName) "parsedcomment");
      if (xattribute19 != null)
        watchlistSelect.parsedcomment = ValueParser.ParseString(xattribute19.Value);
      XAttribute xattribute20 = element.Attribute((XName) "logid");
      if (xattribute20 != null && xattribute20.Value != "")
        watchlistSelect.logid = new long?(ValueParser.ParseInt64(xattribute20.Value));
      XAttribute xattribute21 = element.Attribute((XName) "logtype");
      if (xattribute21 != null && xattribute21.Value != "")
        watchlistSelect.logtype = new watchlistlogtype(xattribute21.Value);
      XAttribute xattribute22 = element.Attribute((XName) "logaction");
      if (xattribute22 != null)
        watchlistSelect.logaction = ValueParser.ParseString(xattribute22.Value);
      return watchlistSelect;
    }

    public override string ToString()
    {
      return string.Format("type: {0}; pageid: {1}; revid: {2}; old_revid: {3}; ns: {4}; title: {5}; user: {6}; anon: {7}; userid: {8}; new: {9}; minor: {10}; bot: {11}; patrolled: {12}; timestamp: {13}; oldlen: {14}; newlen: {15}; notificationtimestamp: {16}; comment: {17}; parsedcomment: {18}; logid: {19}; logtype: {20}; logaction: {21}", (object) this.type, (object) this.pageid, (object) this.revid, (object) this.old_revid, (object) this.ns, (object) this.title, (object) this.user, (object) (bool) (this.anon ? 1 : 0), (object) this.userid, (object) (bool) (this.@new ? 1 : 0), (object) (bool) (this.minor ? 1 : 0), (object) (bool) (this.bot ? 1 : 0), (object) (bool) (this.patrolled ? 1 : 0), (object) this.timestamp, (object) this.oldlen, (object) this.newlen, (object) this.notificationtimestamp, (object) this.comment, (object) this.parsedcomment, (object) this.logid, (object) this.logtype, (object) this.logaction);
    }
  }
}
