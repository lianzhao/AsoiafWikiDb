// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.logeventsSelect
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
  public sealed class logeventsSelect
  {
    public long logid { get; private set; }

    public long pageid { get; private set; }

    public Namespace ns { get; private set; }

    public string title { get; private set; }

    public logeventstype type { get; private set; }

    public string action { get; private set; }

    public bool actionhidden { get; private set; }

    public bool userhidden { get; private set; }

    public string user { get; private set; }

    public bool anon { get; private set; }

    public long? userid { get; private set; }

    public DateTime timestamp { get; private set; }

    public bool commenthidden { get; private set; }

    public string comment { get; private set; }

    public string parsedcomment { get; private set; }

    private logeventsSelect()
    {
    }

    public static logeventsSelect Parse(XElement element, WikiInfo wiki)
    {
      logeventsSelect logeventsSelect = new logeventsSelect();
      XAttribute xattribute1 = element.Attribute((XName) "logid");
      if (xattribute1 != null && xattribute1.Value != "")
        logeventsSelect.logid = ValueParser.ParseInt64(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "pageid");
      if (xattribute2 != null && xattribute2.Value != "")
        logeventsSelect.pageid = ValueParser.ParseInt64(xattribute2.Value);
      XAttribute xattribute3 = element.Attribute((XName) "ns");
      if (xattribute3 != null && xattribute3.Value != "")
        logeventsSelect.ns = ValueParser.ParseNamespace(xattribute3.Value, wiki);
      XAttribute xattribute4 = element.Attribute((XName) "title");
      if (xattribute4 != null)
        logeventsSelect.title = ValueParser.ParseString(xattribute4.Value);
      XAttribute xattribute5 = element.Attribute((XName) "type");
      if (xattribute5 != null && xattribute5.Value != "")
        logeventsSelect.type = new logeventstype(xattribute5.Value);
      XAttribute xattribute6 = element.Attribute((XName) "action");
      if (xattribute6 != null)
        logeventsSelect.action = ValueParser.ParseString(xattribute6.Value);
      XAttribute xattribute7 = element.Attribute((XName) "actionhidden");
      if (xattribute7 != null)
        logeventsSelect.actionhidden = ValueParser.ParseBoolean(xattribute7.Value);
      XAttribute xattribute8 = element.Attribute((XName) "userhidden");
      if (xattribute8 != null)
        logeventsSelect.userhidden = ValueParser.ParseBoolean(xattribute8.Value);
      XAttribute xattribute9 = element.Attribute((XName) "user");
      if (xattribute9 != null)
        logeventsSelect.user = ValueParser.ParseString(xattribute9.Value);
      XAttribute xattribute10 = element.Attribute((XName) "anon");
      if (xattribute10 != null)
        logeventsSelect.anon = ValueParser.ParseBoolean(xattribute10.Value);
      XAttribute xattribute11 = element.Attribute((XName) "userid");
      if (xattribute11 != null && xattribute11.Value != "")
        logeventsSelect.userid = new long?(ValueParser.ParseInt64(xattribute11.Value));
      XAttribute xattribute12 = element.Attribute((XName) "timestamp");
      if (xattribute12 != null && xattribute12.Value != "")
        logeventsSelect.timestamp = ValueParser.ParseDateTime(xattribute12.Value);
      XAttribute xattribute13 = element.Attribute((XName) "commenthidden");
      if (xattribute13 != null)
        logeventsSelect.commenthidden = ValueParser.ParseBoolean(xattribute13.Value);
      XAttribute xattribute14 = element.Attribute((XName) "comment");
      if (xattribute14 != null)
        logeventsSelect.comment = ValueParser.ParseString(xattribute14.Value);
      XAttribute xattribute15 = element.Attribute((XName) "parsedcomment");
      if (xattribute15 != null)
        logeventsSelect.parsedcomment = ValueParser.ParseString(xattribute15.Value);
      return logeventsSelect;
    }

    public override string ToString()
    {
      return string.Format("logid: {0}; pageid: {1}; ns: {2}; title: {3}; type: {4}; action: {5}; actionhidden: {6}; userhidden: {7}; user: {8}; anon: {9}; userid: {10}; timestamp: {11}; commenthidden: {12}; comment: {13}; parsedcomment: {14}", (object) this.logid, (object) this.pageid, (object) this.ns, (object) this.title, (object) this.type, (object) this.action, (object) (bool) (this.actionhidden ? 1 : 0), (object) (bool) (this.userhidden ? 1 : 0), (object) this.user, (object) (bool) (this.anon ? 1 : 0), (object) this.userid, (object) this.timestamp, (object) (bool) (this.commenthidden ? 1 : 0), (object) this.comment, (object) this.parsedcomment);
    }
  }
}
