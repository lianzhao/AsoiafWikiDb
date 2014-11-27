// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.allimagesSelect
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki;
using LinqToWiki.Internals;
using System;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class allimagesSelect
  {
    public string name { get; private set; }

    public Namespace ns { get; private set; }

    public string title { get; private set; }

    public DateTime timestamp { get; private set; }

    public bool userhidden { get; private set; }

    public string user { get; private set; }

    public bool anon { get; private set; }

    public long userid { get; private set; }

    public int size { get; private set; }

    public int width { get; private set; }

    public int height { get; private set; }

    public int? pagecount { get; private set; }

    public bool commenthidden { get; private set; }

    public string comment { get; private set; }

    public string parsedcomment { get; private set; }

    public bool filehidden { get; private set; }

    public string thumburl { get; private set; }

    public int? thumbwidth { get; private set; }

    public int? thumbheight { get; private set; }

    public string thumberror { get; private set; }

    public string url { get; private set; }

    public string descriptionurl { get; private set; }

    public string sha1 { get; private set; }

    public string mime { get; private set; }

    public string mediatype { get; private set; }

    public int? bitdepth { get; private set; }

    private allimagesSelect()
    {
    }

    public static allimagesSelect Parse(XElement element, WikiInfo wiki)
    {
      allimagesSelect allimagesSelect = new allimagesSelect();
      XAttribute xattribute1 = element.Attribute((XName) "name");
      if (xattribute1 != null)
        allimagesSelect.name = ValueParser.ParseString(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "ns");
      if (xattribute2 != null && xattribute2.Value != "")
        allimagesSelect.ns = ValueParser.ParseNamespace(xattribute2.Value, wiki);
      XAttribute xattribute3 = element.Attribute((XName) "title");
      if (xattribute3 != null)
        allimagesSelect.title = ValueParser.ParseString(xattribute3.Value);
      XAttribute xattribute4 = element.Attribute((XName) "timestamp");
      if (xattribute4 != null && xattribute4.Value != "")
        allimagesSelect.timestamp = ValueParser.ParseDateTime(xattribute4.Value);
      XAttribute xattribute5 = element.Attribute((XName) "userhidden");
      if (xattribute5 != null)
        allimagesSelect.userhidden = ValueParser.ParseBoolean(xattribute5.Value);
      XAttribute xattribute6 = element.Attribute((XName) "user");
      if (xattribute6 != null)
        allimagesSelect.user = ValueParser.ParseString(xattribute6.Value);
      XAttribute xattribute7 = element.Attribute((XName) "anon");
      if (xattribute7 != null)
        allimagesSelect.anon = ValueParser.ParseBoolean(xattribute7.Value);
      XAttribute xattribute8 = element.Attribute((XName) "userid");
      if (xattribute8 != null && xattribute8.Value != "")
        allimagesSelect.userid = ValueParser.ParseInt64(xattribute8.Value);
      XAttribute xattribute9 = element.Attribute((XName) "size");
      if (xattribute9 != null && xattribute9.Value != "")
        allimagesSelect.size = ValueParser.ParseInt32(xattribute9.Value);
      XAttribute xattribute10 = element.Attribute((XName) "width");
      if (xattribute10 != null && xattribute10.Value != "")
        allimagesSelect.width = ValueParser.ParseInt32(xattribute10.Value);
      XAttribute xattribute11 = element.Attribute((XName) "height");
      if (xattribute11 != null && xattribute11.Value != "")
        allimagesSelect.height = ValueParser.ParseInt32(xattribute11.Value);
      XAttribute xattribute12 = element.Attribute((XName) "pagecount");
      if (xattribute12 != null && xattribute12.Value != "")
        allimagesSelect.pagecount = new int?(ValueParser.ParseInt32(xattribute12.Value));
      XAttribute xattribute13 = element.Attribute((XName) "commenthidden");
      if (xattribute13 != null)
        allimagesSelect.commenthidden = ValueParser.ParseBoolean(xattribute13.Value);
      XAttribute xattribute14 = element.Attribute((XName) "comment");
      if (xattribute14 != null)
        allimagesSelect.comment = ValueParser.ParseString(xattribute14.Value);
      XAttribute xattribute15 = element.Attribute((XName) "parsedcomment");
      if (xattribute15 != null)
        allimagesSelect.parsedcomment = ValueParser.ParseString(xattribute15.Value);
      XAttribute xattribute16 = element.Attribute((XName) "filehidden");
      if (xattribute16 != null)
        allimagesSelect.filehidden = ValueParser.ParseBoolean(xattribute16.Value);
      XAttribute xattribute17 = element.Attribute((XName) "thumburl");
      if (xattribute17 != null)
        allimagesSelect.thumburl = ValueParser.ParseString(xattribute17.Value);
      XAttribute xattribute18 = element.Attribute((XName) "thumbwidth");
      if (xattribute18 != null && xattribute18.Value != "")
        allimagesSelect.thumbwidth = new int?(ValueParser.ParseInt32(xattribute18.Value));
      XAttribute xattribute19 = element.Attribute((XName) "thumbheight");
      if (xattribute19 != null && xattribute19.Value != "")
        allimagesSelect.thumbheight = new int?(ValueParser.ParseInt32(xattribute19.Value));
      XAttribute xattribute20 = element.Attribute((XName) "thumberror");
      if (xattribute20 != null)
        allimagesSelect.thumberror = ValueParser.ParseString(xattribute20.Value);
      XAttribute xattribute21 = element.Attribute((XName) "url");
      if (xattribute21 != null)
        allimagesSelect.url = ValueParser.ParseString(xattribute21.Value);
      XAttribute xattribute22 = element.Attribute((XName) "descriptionurl");
      if (xattribute22 != null)
        allimagesSelect.descriptionurl = ValueParser.ParseString(xattribute22.Value);
      XAttribute xattribute23 = element.Attribute((XName) "sha1");
      if (xattribute23 != null)
        allimagesSelect.sha1 = ValueParser.ParseString(xattribute23.Value);
      XAttribute xattribute24 = element.Attribute((XName) "mime");
      if (xattribute24 != null)
        allimagesSelect.mime = ValueParser.ParseString(xattribute24.Value);
      XAttribute xattribute25 = element.Attribute((XName) "mediatype");
      if (xattribute25 != null)
        allimagesSelect.mediatype = ValueParser.ParseString(xattribute25.Value);
      XAttribute xattribute26 = element.Attribute((XName) "bitdepth");
      if (xattribute26 != null && xattribute26.Value != "")
        allimagesSelect.bitdepth = new int?(ValueParser.ParseInt32(xattribute26.Value));
      return allimagesSelect;
    }

    public override string ToString()
    {
      return string.Format("name: {0}; ns: {1}; title: {2}; timestamp: {3}; userhidden: {4}; user: {5}; anon: {6}; userid: {7}; size: {8}; width: {9}; height: {10}; pagecount: {11}; commenthidden: {12}; comment: {13}; parsedcomment: {14}; filehidden: {15}; thumburl: {16}; thumbwidth: {17}; thumbheight: {18}; thumberror: {19}; url: {20}; descriptionurl: {21}; sha1: {22}; mime: {23}; mediatype: {24}; bitdepth: {25}", (object) this.name, (object) this.ns, (object) this.title, (object) this.timestamp, (this.userhidden ? 1 : 0), (object) this.user, (this.anon ? 1 : 0), (object) this.userid, (object) this.size, (object) this.width, (object) this.height, (object) this.pagecount, (this.commenthidden ? 1 : 0), (object) this.comment, (object) this.parsedcomment, (this.filehidden ? 1 : 0), (object) this.thumburl, (object) this.thumbwidth, (object) this.thumbheight, (object) this.thumberror, (object) this.url, (object) this.descriptionurl, (object) this.sha1, (object) this.mime, (object) this.mediatype, (object) this.bitdepth);
    }
  }
}
