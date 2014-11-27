// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.videoinfoSelect
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;
using System;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class videoinfoSelect
  {
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

    public string thumbmime { get; private set; }

    public string mediatype { get; private set; }

    public string archivename { get; private set; }

    public int? bitdepth { get; private set; }

    private videoinfoSelect()
    {
    }

    public static videoinfoSelect Parse(XElement element, WikiInfo wiki)
    {
      videoinfoSelect videoinfoSelect = new videoinfoSelect();
      XAttribute xattribute1 = element.Attribute((XName) "timestamp");
      if (xattribute1 != null && xattribute1.Value != "")
        videoinfoSelect.timestamp = ValueParser.ParseDateTime(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "userhidden");
      if (xattribute2 != null)
        videoinfoSelect.userhidden = ValueParser.ParseBoolean(xattribute2.Value);
      XAttribute xattribute3 = element.Attribute((XName) "user");
      if (xattribute3 != null)
        videoinfoSelect.user = ValueParser.ParseString(xattribute3.Value);
      XAttribute xattribute4 = element.Attribute((XName) "anon");
      if (xattribute4 != null)
        videoinfoSelect.anon = ValueParser.ParseBoolean(xattribute4.Value);
      XAttribute xattribute5 = element.Attribute((XName) "userid");
      if (xattribute5 != null && xattribute5.Value != "")
        videoinfoSelect.userid = ValueParser.ParseInt64(xattribute5.Value);
      XAttribute xattribute6 = element.Attribute((XName) "size");
      if (xattribute6 != null && xattribute6.Value != "")
        videoinfoSelect.size = ValueParser.ParseInt32(xattribute6.Value);
      XAttribute xattribute7 = element.Attribute((XName) "width");
      if (xattribute7 != null && xattribute7.Value != "")
        videoinfoSelect.width = ValueParser.ParseInt32(xattribute7.Value);
      XAttribute xattribute8 = element.Attribute((XName) "height");
      if (xattribute8 != null && xattribute8.Value != "")
        videoinfoSelect.height = ValueParser.ParseInt32(xattribute8.Value);
      XAttribute xattribute9 = element.Attribute((XName) "pagecount");
      if (xattribute9 != null && xattribute9.Value != "")
        videoinfoSelect.pagecount = new int?(ValueParser.ParseInt32(xattribute9.Value));
      XAttribute xattribute10 = element.Attribute((XName) "commenthidden");
      if (xattribute10 != null)
        videoinfoSelect.commenthidden = ValueParser.ParseBoolean(xattribute10.Value);
      XAttribute xattribute11 = element.Attribute((XName) "comment");
      if (xattribute11 != null)
        videoinfoSelect.comment = ValueParser.ParseString(xattribute11.Value);
      XAttribute xattribute12 = element.Attribute((XName) "parsedcomment");
      if (xattribute12 != null)
        videoinfoSelect.parsedcomment = ValueParser.ParseString(xattribute12.Value);
      XAttribute xattribute13 = element.Attribute((XName) "filehidden");
      if (xattribute13 != null)
        videoinfoSelect.filehidden = ValueParser.ParseBoolean(xattribute13.Value);
      XAttribute xattribute14 = element.Attribute((XName) "thumburl");
      if (xattribute14 != null)
        videoinfoSelect.thumburl = ValueParser.ParseString(xattribute14.Value);
      XAttribute xattribute15 = element.Attribute((XName) "thumbwidth");
      if (xattribute15 != null && xattribute15.Value != "")
        videoinfoSelect.thumbwidth = new int?(ValueParser.ParseInt32(xattribute15.Value));
      XAttribute xattribute16 = element.Attribute((XName) "thumbheight");
      if (xattribute16 != null && xattribute16.Value != "")
        videoinfoSelect.thumbheight = new int?(ValueParser.ParseInt32(xattribute16.Value));
      XAttribute xattribute17 = element.Attribute((XName) "thumberror");
      if (xattribute17 != null)
        videoinfoSelect.thumberror = ValueParser.ParseString(xattribute17.Value);
      XAttribute xattribute18 = element.Attribute((XName) "url");
      if (xattribute18 != null)
        videoinfoSelect.url = ValueParser.ParseString(xattribute18.Value);
      XAttribute xattribute19 = element.Attribute((XName) "descriptionurl");
      if (xattribute19 != null)
        videoinfoSelect.descriptionurl = ValueParser.ParseString(xattribute19.Value);
      XAttribute xattribute20 = element.Attribute((XName) "sha1");
      if (xattribute20 != null)
        videoinfoSelect.sha1 = ValueParser.ParseString(xattribute20.Value);
      XAttribute xattribute21 = element.Attribute((XName) "mime");
      if (xattribute21 != null)
        videoinfoSelect.mime = ValueParser.ParseString(xattribute21.Value);
      XAttribute xattribute22 = element.Attribute((XName) "thumbmime");
      if (xattribute22 != null)
        videoinfoSelect.thumbmime = ValueParser.ParseString(xattribute22.Value);
      XAttribute xattribute23 = element.Attribute((XName) "mediatype");
      if (xattribute23 != null)
        videoinfoSelect.mediatype = ValueParser.ParseString(xattribute23.Value);
      XAttribute xattribute24 = element.Attribute((XName) "archivename");
      if (xattribute24 != null)
        videoinfoSelect.archivename = ValueParser.ParseString(xattribute24.Value);
      XAttribute xattribute25 = element.Attribute((XName) "bitdepth");
      if (xattribute25 != null && xattribute25.Value != "")
        videoinfoSelect.bitdepth = new int?(ValueParser.ParseInt32(xattribute25.Value));
      return videoinfoSelect;
    }

    public override string ToString()
    {
      return string.Format("timestamp: {0}; userhidden: {1}; user: {2}; anon: {3}; userid: {4}; size: {5}; width: {6}; height: {7}; pagecount: {8}; commenthidden: {9}; comment: {10}; parsedcomment: {11}; filehidden: {12}; thumburl: {13}; thumbwidth: {14}; thumbheight: {15}; thumberror: {16}; url: {17}; descriptionurl: {18}; sha1: {19}; mime: {20}; thumbmime: {21}; mediatype: {22}; archivename: {23}; bitdepth: {24}", (object) this.timestamp, (object) (bool) (this.userhidden ? 1 : 0), (object) this.user, (object) (bool) (this.anon ? 1 : 0), (object) this.userid, (object) this.size, (object) this.width, (object) this.height, (object) this.pagecount, (object) (bool) (this.commenthidden ? 1 : 0), (object) this.comment, (object) this.parsedcomment, (object) (bool) (this.filehidden ? 1 : 0), (object) this.thumburl, (object) this.thumbwidth, (object) this.thumbheight, (object) this.thumberror, (object) this.url, (object) this.descriptionurl, (object) this.sha1, (object) this.mime, (object) this.thumbmime, (object) this.mediatype, (object) this.archivename, (object) this.bitdepth);
    }
  }
}
