// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.recentchangesSelect
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
  public sealed class recentchangesSelect
  {
    public recentchangestype type { get; private set; }

    public string patroltoken { get; private set; }

    public Namespace ns { get; private set; }

    public string title { get; private set; }

    public Namespace new_ns { get; private set; }

    public string new_title { get; private set; }

    public long rcid { get; private set; }

    public long pageid { get; private set; }

    public long revid { get; private set; }

    public long old_revid { get; private set; }

    public string user { get; private set; }

    public bool anon { get; private set; }

    public long userid { get; private set; }

    public bool bot { get; private set; }

    public bool @new { get; private set; }

    public bool minor { get; private set; }

    public int oldlen { get; private set; }

    public int newlen { get; private set; }

    public DateTime timestamp { get; private set; }

    public string comment { get; private set; }

    public string parsedcomment { get; private set; }

    public bool redirect { get; private set; }

    public bool patrolled { get; private set; }

    public long? logid { get; private set; }

    public recentchangeslogtype logtype { get; private set; }

    public string logaction { get; private set; }

    public string sha1 { get; private set; }

    public bool? sha1hidden { get; private set; }

    private recentchangesSelect()
    {
    }

    public static recentchangesSelect Parse(XElement element, WikiInfo wiki)
    {
      recentchangesSelect recentchangesSelect = new recentchangesSelect();
      XAttribute xattribute1 = element.Attribute((XName) "type");
      if (xattribute1 != null && xattribute1.Value != "")
        recentchangesSelect.type = new recentchangestype(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "patroltoken");
      if (xattribute2 != null)
        recentchangesSelect.patroltoken = ValueParser.ParseString(xattribute2.Value);
      XAttribute xattribute3 = element.Attribute((XName) "ns");
      if (xattribute3 != null && xattribute3.Value != "")
        recentchangesSelect.ns = ValueParser.ParseNamespace(xattribute3.Value, wiki);
      XAttribute xattribute4 = element.Attribute((XName) "title");
      if (xattribute4 != null)
        recentchangesSelect.title = ValueParser.ParseString(xattribute4.Value);
      XAttribute xattribute5 = element.Attribute((XName) "new_ns");
      if (xattribute5 != null && xattribute5.Value != "")
        recentchangesSelect.new_ns = ValueParser.ParseNamespace(xattribute5.Value, wiki);
      XAttribute xattribute6 = element.Attribute((XName) "new_title");
      if (xattribute6 != null)
        recentchangesSelect.new_title = ValueParser.ParseString(xattribute6.Value);
      XAttribute xattribute7 = element.Attribute((XName) "rcid");
      if (xattribute7 != null && xattribute7.Value != "")
        recentchangesSelect.rcid = ValueParser.ParseInt64(xattribute7.Value);
      XAttribute xattribute8 = element.Attribute((XName) "pageid");
      if (xattribute8 != null && xattribute8.Value != "")
        recentchangesSelect.pageid = ValueParser.ParseInt64(xattribute8.Value);
      XAttribute xattribute9 = element.Attribute((XName) "revid");
      if (xattribute9 != null && xattribute9.Value != "")
        recentchangesSelect.revid = ValueParser.ParseInt64(xattribute9.Value);
      XAttribute xattribute10 = element.Attribute((XName) "old_revid");
      if (xattribute10 != null && xattribute10.Value != "")
        recentchangesSelect.old_revid = ValueParser.ParseInt64(xattribute10.Value);
      XAttribute xattribute11 = element.Attribute((XName) "user");
      if (xattribute11 != null)
        recentchangesSelect.user = ValueParser.ParseString(xattribute11.Value);
      XAttribute xattribute12 = element.Attribute((XName) "anon");
      if (xattribute12 != null)
        recentchangesSelect.anon = ValueParser.ParseBoolean(xattribute12.Value);
      XAttribute xattribute13 = element.Attribute((XName) "userid");
      if (xattribute13 != null && xattribute13.Value != "")
        recentchangesSelect.userid = ValueParser.ParseInt64(xattribute13.Value);
      XAttribute xattribute14 = element.Attribute((XName) "bot");
      if (xattribute14 != null)
        recentchangesSelect.bot = ValueParser.ParseBoolean(xattribute14.Value);
      XAttribute xattribute15 = element.Attribute((XName) "new");
      if (xattribute15 != null)
        recentchangesSelect.@new = ValueParser.ParseBoolean(xattribute15.Value);
      XAttribute xattribute16 = element.Attribute((XName) "minor");
      if (xattribute16 != null)
        recentchangesSelect.minor = ValueParser.ParseBoolean(xattribute16.Value);
      XAttribute xattribute17 = element.Attribute((XName) "oldlen");
      if (xattribute17 != null && xattribute17.Value != "")
        recentchangesSelect.oldlen = ValueParser.ParseInt32(xattribute17.Value);
      XAttribute xattribute18 = element.Attribute((XName) "newlen");
      if (xattribute18 != null && xattribute18.Value != "")
        recentchangesSelect.newlen = ValueParser.ParseInt32(xattribute18.Value);
      XAttribute xattribute19 = element.Attribute((XName) "timestamp");
      if (xattribute19 != null && xattribute19.Value != "")
        recentchangesSelect.timestamp = ValueParser.ParseDateTime(xattribute19.Value);
      XAttribute xattribute20 = element.Attribute((XName) "comment");
      if (xattribute20 != null)
        recentchangesSelect.comment = ValueParser.ParseString(xattribute20.Value);
      XAttribute xattribute21 = element.Attribute((XName) "parsedcomment");
      if (xattribute21 != null)
        recentchangesSelect.parsedcomment = ValueParser.ParseString(xattribute21.Value);
      XAttribute xattribute22 = element.Attribute((XName) "redirect");
      if (xattribute22 != null)
        recentchangesSelect.redirect = ValueParser.ParseBoolean(xattribute22.Value);
      XAttribute xattribute23 = element.Attribute((XName) "patrolled");
      if (xattribute23 != null)
        recentchangesSelect.patrolled = ValueParser.ParseBoolean(xattribute23.Value);
      XAttribute xattribute24 = element.Attribute((XName) "logid");
      if (xattribute24 != null && xattribute24.Value != "")
        recentchangesSelect.logid = new long?(ValueParser.ParseInt64(xattribute24.Value));
      XAttribute xattribute25 = element.Attribute((XName) "logtype");
      if (xattribute25 != null && xattribute25.Value != "")
        recentchangesSelect.logtype = new recentchangeslogtype(xattribute25.Value);
      XAttribute xattribute26 = element.Attribute((XName) "logaction");
      if (xattribute26 != null)
        recentchangesSelect.logaction = ValueParser.ParseString(xattribute26.Value);
      XAttribute xattribute27 = element.Attribute((XName) "sha1");
      if (xattribute27 != null)
        recentchangesSelect.sha1 = ValueParser.ParseString(xattribute27.Value);
      XAttribute xattribute28 = element.Attribute((XName) "sha1hidden");
      if (xattribute28 != null)
        recentchangesSelect.sha1hidden = new bool?(ValueParser.ParseBoolean(xattribute28.Value));
      return recentchangesSelect;
    }

    public override string ToString()
    {
      return string.Format("type: {0}; patroltoken: {1}; ns: {2}; title: {3}; new_ns: {4}; new_title: {5}; rcid: {6}; pageid: {7}; revid: {8}; old_revid: {9}; user: {10}; anon: {11}; userid: {12}; bot: {13}; new: {14}; minor: {15}; oldlen: {16}; newlen: {17}; timestamp: {18}; comment: {19}; parsedcomment: {20}; redirect: {21}; patrolled: {22}; logid: {23}; logtype: {24}; logaction: {25}; sha1: {26}; sha1hidden: {27}", (object) this.type, (object) this.patroltoken, (object) this.ns, (object) this.title, (object) this.new_ns, (object) this.new_title, (object) this.rcid, (object) this.pageid, (object) this.revid, (object) this.old_revid, (object) this.user, (this.anon ? 1 : 0), (object) this.userid, (this.bot ? 1 : 0), (this.@new ? 1 : 0), (this.minor ? 1 : 0), (object) this.oldlen, (object) this.newlen, (object) this.timestamp, (object) this.comment, (object) this.parsedcomment, (this.redirect ? 1 : 0), (this.patrolled ? 1 : 0), (object) this.logid, (object) this.logtype, (object) this.logaction, (object) this.sha1, (object) this.sha1hidden);
    }
  }
}
