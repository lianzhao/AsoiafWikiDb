// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.revisionsSelect
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki;
using LinqToWiki.Internals;
using System;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class revisionsSelect : IFirst
  {
    public string rollbacktoken { get; private set; }

    public long revid { get; private set; }

    public long? parentid { get; private set; }

    public bool minor { get; private set; }

    public bool userhidden { get; private set; }

    public string user { get; private set; }

    public bool anon { get; private set; }

    public long userid { get; private set; }

    public DateTime timestamp { get; private set; }

    public int size { get; private set; }

    public string sha1 { get; private set; }

    public bool commenthidden { get; private set; }

    public string comment { get; private set; }

    public string parsedcomment { get; private set; }

    public string value { get; private set; }

    public bool texthidden { get; private set; }

    public bool textmissing { get; private set; }

    public string contentmodel { get; private set; }

    private revisionsSelect()
    {
    }

    public static revisionsSelect Parse(XElement element, WikiInfo wiki)
    {
      revisionsSelect revisionsSelect = new revisionsSelect();
      XAttribute xattribute1 = element.Attribute((XName) "rollbacktoken");
      if (xattribute1 != null)
        revisionsSelect.rollbacktoken = ValueParser.ParseString(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "revid");
      if (xattribute2 != null && xattribute2.Value != "")
        revisionsSelect.revid = ValueParser.ParseInt64(xattribute2.Value);
      XAttribute xattribute3 = element.Attribute((XName) "parentid");
      if (xattribute3 != null && xattribute3.Value != "")
        revisionsSelect.parentid = new long?(ValueParser.ParseInt64(xattribute3.Value));
      XAttribute xattribute4 = element.Attribute((XName) "minor");
      if (xattribute4 != null)
        revisionsSelect.minor = ValueParser.ParseBoolean(xattribute4.Value);
      XAttribute xattribute5 = element.Attribute((XName) "userhidden");
      if (xattribute5 != null)
        revisionsSelect.userhidden = ValueParser.ParseBoolean(xattribute5.Value);
      XAttribute xattribute6 = element.Attribute((XName) "user");
      if (xattribute6 != null)
        revisionsSelect.user = ValueParser.ParseString(xattribute6.Value);
      XAttribute xattribute7 = element.Attribute((XName) "anon");
      if (xattribute7 != null)
        revisionsSelect.anon = ValueParser.ParseBoolean(xattribute7.Value);
      XAttribute xattribute8 = element.Attribute((XName) "userid");
      if (xattribute8 != null && xattribute8.Value != "")
        revisionsSelect.userid = ValueParser.ParseInt64(xattribute8.Value);
      XAttribute xattribute9 = element.Attribute((XName) "timestamp");
      if (xattribute9 != null && xattribute9.Value != "")
        revisionsSelect.timestamp = ValueParser.ParseDateTime(xattribute9.Value);
      XAttribute xattribute10 = element.Attribute((XName) "size");
      if (xattribute10 != null && xattribute10.Value != "")
        revisionsSelect.size = ValueParser.ParseInt32(xattribute10.Value);
      XAttribute xattribute11 = element.Attribute((XName) "sha1");
      if (xattribute11 != null)
        revisionsSelect.sha1 = ValueParser.ParseString(xattribute11.Value);
      XAttribute xattribute12 = element.Attribute((XName) "commenthidden");
      if (xattribute12 != null)
        revisionsSelect.commenthidden = ValueParser.ParseBoolean(xattribute12.Value);
      XAttribute xattribute13 = element.Attribute((XName) "comment");
      if (xattribute13 != null)
        revisionsSelect.comment = ValueParser.ParseString(xattribute13.Value);
      XAttribute xattribute14 = element.Attribute((XName) "parsedcomment");
      if (xattribute14 != null)
        revisionsSelect.parsedcomment = ValueParser.ParseString(xattribute14.Value);
      XElement xelement = element;
      revisionsSelect.value = ValueParser.ParseString(xelement.Value);
      XAttribute xattribute15 = element.Attribute((XName) "texthidden");
      if (xattribute15 != null)
        revisionsSelect.texthidden = ValueParser.ParseBoolean(xattribute15.Value);
      XAttribute xattribute16 = element.Attribute((XName) "textmissing");
      if (xattribute16 != null)
        revisionsSelect.textmissing = ValueParser.ParseBoolean(xattribute16.Value);
      XAttribute xattribute17 = element.Attribute((XName) "contentmodel");
      if (xattribute17 != null)
        revisionsSelect.contentmodel = ValueParser.ParseString(xattribute17.Value);
      return revisionsSelect;
    }

    public override string ToString()
    {
      return string.Format("rollbacktoken: {0}; revid: {1}; parentid: {2}; minor: {3}; userhidden: {4}; user: {5}; anon: {6}; userid: {7}; timestamp: {8}; size: {9}; sha1: {10}; commenthidden: {11}; comment: {12}; parsedcomment: {13}; value: {14}; texthidden: {15}; textmissing: {16}; contentmodel: {17}", (object) this.rollbacktoken, (object) this.revid, (object) this.parentid, (object) (bool) (this.minor ? 1 : 0), (object) (bool) (this.userhidden ? 1 : 0), (object) this.user, (object) (bool) (this.anon ? 1 : 0), (object) this.userid, (object) this.timestamp, (object) this.size, (object) this.sha1, (object) (bool) (this.commenthidden ? 1 : 0), (object) this.comment, (object) this.parsedcomment, (object) this.value, (object) (bool) (this.texthidden ? 1 : 0), (object) (bool) (this.textmissing ? 1 : 0), (object) this.contentmodel);
    }
  }
}
