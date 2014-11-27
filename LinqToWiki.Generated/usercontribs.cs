// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.usercontribsSelect
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki;
using LinqToWiki.Internals;
using System;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class usercontribsSelect
  {
    public long userid { get; private set; }

    public string user { get; private set; }

    public bool userhidden { get; private set; }

    public long pageid { get; private set; }

    public long revid { get; private set; }

    public long? parentid { get; private set; }

    public Namespace ns { get; private set; }

    public string title { get; private set; }

    public DateTime timestamp { get; private set; }

    public bool @new { get; private set; }

    public bool minor { get; private set; }

    public bool top { get; private set; }

    public bool commenthidden { get; private set; }

    public string comment { get; private set; }

    public string parsedcomment { get; private set; }

    public bool patrolled { get; private set; }

    public int? size { get; private set; }

    public int? sizediff { get; private set; }

    private usercontribsSelect()
    {
    }

    public static usercontribsSelect Parse(XElement element, WikiInfo wiki)
    {
      usercontribsSelect usercontribsSelect = new usercontribsSelect();
      XAttribute xattribute1 = element.Attribute((XName) "userid");
      if (xattribute1 != null && xattribute1.Value != "")
        usercontribsSelect.userid = ValueParser.ParseInt64(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "user");
      if (xattribute2 != null)
        usercontribsSelect.user = ValueParser.ParseString(xattribute2.Value);
      XAttribute xattribute3 = element.Attribute((XName) "userhidden");
      if (xattribute3 != null)
        usercontribsSelect.userhidden = ValueParser.ParseBoolean(xattribute3.Value);
      XAttribute xattribute4 = element.Attribute((XName) "pageid");
      if (xattribute4 != null && xattribute4.Value != "")
        usercontribsSelect.pageid = ValueParser.ParseInt64(xattribute4.Value);
      XAttribute xattribute5 = element.Attribute((XName) "revid");
      if (xattribute5 != null && xattribute5.Value != "")
        usercontribsSelect.revid = ValueParser.ParseInt64(xattribute5.Value);
      XAttribute xattribute6 = element.Attribute((XName) "parentid");
      if (xattribute6 != null && xattribute6.Value != "")
        usercontribsSelect.parentid = new long?(ValueParser.ParseInt64(xattribute6.Value));
      XAttribute xattribute7 = element.Attribute((XName) "ns");
      if (xattribute7 != null && xattribute7.Value != "")
        usercontribsSelect.ns = ValueParser.ParseNamespace(xattribute7.Value, wiki);
      XAttribute xattribute8 = element.Attribute((XName) "title");
      if (xattribute8 != null)
        usercontribsSelect.title = ValueParser.ParseString(xattribute8.Value);
      XAttribute xattribute9 = element.Attribute((XName) "timestamp");
      if (xattribute9 != null && xattribute9.Value != "")
        usercontribsSelect.timestamp = ValueParser.ParseDateTime(xattribute9.Value);
      XAttribute xattribute10 = element.Attribute((XName) "new");
      if (xattribute10 != null)
        usercontribsSelect.@new = ValueParser.ParseBoolean(xattribute10.Value);
      XAttribute xattribute11 = element.Attribute((XName) "minor");
      if (xattribute11 != null)
        usercontribsSelect.minor = ValueParser.ParseBoolean(xattribute11.Value);
      XAttribute xattribute12 = element.Attribute((XName) "top");
      if (xattribute12 != null)
        usercontribsSelect.top = ValueParser.ParseBoolean(xattribute12.Value);
      XAttribute xattribute13 = element.Attribute((XName) "commenthidden");
      if (xattribute13 != null)
        usercontribsSelect.commenthidden = ValueParser.ParseBoolean(xattribute13.Value);
      XAttribute xattribute14 = element.Attribute((XName) "comment");
      if (xattribute14 != null)
        usercontribsSelect.comment = ValueParser.ParseString(xattribute14.Value);
      XAttribute xattribute15 = element.Attribute((XName) "parsedcomment");
      if (xattribute15 != null)
        usercontribsSelect.parsedcomment = ValueParser.ParseString(xattribute15.Value);
      XAttribute xattribute16 = element.Attribute((XName) "patrolled");
      if (xattribute16 != null)
        usercontribsSelect.patrolled = ValueParser.ParseBoolean(xattribute16.Value);
      XAttribute xattribute17 = element.Attribute((XName) "size");
      if (xattribute17 != null && xattribute17.Value != "")
        usercontribsSelect.size = new int?(ValueParser.ParseInt32(xattribute17.Value));
      XAttribute xattribute18 = element.Attribute((XName) "sizediff");
      if (xattribute18 != null && xattribute18.Value != "")
        usercontribsSelect.sizediff = new int?(ValueParser.ParseInt32(xattribute18.Value));
      return usercontribsSelect;
    }

    public override string ToString()
    {
      return string.Format("userid: {0}; user: {1}; userhidden: {2}; pageid: {3}; revid: {4}; parentid: {5}; ns: {6}; title: {7}; timestamp: {8}; new: {9}; minor: {10}; top: {11}; commenthidden: {12}; comment: {13}; parsedcomment: {14}; patrolled: {15}; size: {16}; sizediff: {17}", (object) this.userid, (object) this.user, (this.userhidden ? 1 : 0), (object) this.pageid, (object) this.revid, (object) this.parentid, (object) this.ns, (object) this.title, (object) this.timestamp, (this.@new ? 1 : 0), (this.minor ? 1 : 0), (this.top ? 1 : 0), (this.commenthidden ? 1 : 0), (object) this.comment, (object) this.parsedcomment, (this.patrolled ? 1 : 0), (object) this.size, (object) this.sizediff);
    }
  }
}
