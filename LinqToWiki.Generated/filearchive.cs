// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.filearchiveSelect
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki;
using LinqToWiki.Internals;
using System;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class filearchiveSelect
  {
    public string name { get; private set; }

    public Namespace ns { get; private set; }

    public string title { get; private set; }

    public bool filehidden { get; private set; }

    public bool commenthidden { get; private set; }

    public bool userhidden { get; private set; }

    public bool suppressed { get; private set; }

    public string sha1 { get; private set; }

    public DateTime timestamp { get; private set; }

    public long userid { get; private set; }

    public string user { get; private set; }

    public int size { get; private set; }

    public int? pagecount { get; private set; }

    public int height { get; private set; }

    public int width { get; private set; }

    public string description { get; private set; }

    public string parseddescription { get; private set; }

    public string metadata { get; private set; }

    public int bitdepth { get; private set; }

    public string mime { get; private set; }

    public string mediatype { get; private set; }

    public string archivename { get; private set; }

    private filearchiveSelect()
    {
    }

    public static filearchiveSelect Parse(XElement element, WikiInfo wiki)
    {
      filearchiveSelect filearchiveSelect = new filearchiveSelect();
      XAttribute xattribute1 = element.Attribute((XName) "name");
      if (xattribute1 != null)
        filearchiveSelect.name = ValueParser.ParseString(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "ns");
      if (xattribute2 != null && xattribute2.Value != "")
        filearchiveSelect.ns = ValueParser.ParseNamespace(xattribute2.Value, wiki);
      XAttribute xattribute3 = element.Attribute((XName) "title");
      if (xattribute3 != null)
        filearchiveSelect.title = ValueParser.ParseString(xattribute3.Value);
      XAttribute xattribute4 = element.Attribute((XName) "filehidden");
      if (xattribute4 != null)
        filearchiveSelect.filehidden = ValueParser.ParseBoolean(xattribute4.Value);
      XAttribute xattribute5 = element.Attribute((XName) "commenthidden");
      if (xattribute5 != null)
        filearchiveSelect.commenthidden = ValueParser.ParseBoolean(xattribute5.Value);
      XAttribute xattribute6 = element.Attribute((XName) "userhidden");
      if (xattribute6 != null)
        filearchiveSelect.userhidden = ValueParser.ParseBoolean(xattribute6.Value);
      XAttribute xattribute7 = element.Attribute((XName) "suppressed");
      if (xattribute7 != null)
        filearchiveSelect.suppressed = ValueParser.ParseBoolean(xattribute7.Value);
      XAttribute xattribute8 = element.Attribute((XName) "sha1");
      if (xattribute8 != null)
        filearchiveSelect.sha1 = ValueParser.ParseString(xattribute8.Value);
      XAttribute xattribute9 = element.Attribute((XName) "timestamp");
      if (xattribute9 != null && xattribute9.Value != "")
        filearchiveSelect.timestamp = ValueParser.ParseDateTime(xattribute9.Value);
      XAttribute xattribute10 = element.Attribute((XName) "userid");
      if (xattribute10 != null && xattribute10.Value != "")
        filearchiveSelect.userid = ValueParser.ParseInt64(xattribute10.Value);
      XAttribute xattribute11 = element.Attribute((XName) "user");
      if (xattribute11 != null)
        filearchiveSelect.user = ValueParser.ParseString(xattribute11.Value);
      XAttribute xattribute12 = element.Attribute((XName) "size");
      if (xattribute12 != null && xattribute12.Value != "")
        filearchiveSelect.size = ValueParser.ParseInt32(xattribute12.Value);
      XAttribute xattribute13 = element.Attribute((XName) "pagecount");
      if (xattribute13 != null && xattribute13.Value != "")
        filearchiveSelect.pagecount = new int?(ValueParser.ParseInt32(xattribute13.Value));
      XAttribute xattribute14 = element.Attribute((XName) "height");
      if (xattribute14 != null && xattribute14.Value != "")
        filearchiveSelect.height = ValueParser.ParseInt32(xattribute14.Value);
      XAttribute xattribute15 = element.Attribute((XName) "width");
      if (xattribute15 != null && xattribute15.Value != "")
        filearchiveSelect.width = ValueParser.ParseInt32(xattribute15.Value);
      XAttribute xattribute16 = element.Attribute((XName) "description");
      if (xattribute16 != null)
        filearchiveSelect.description = ValueParser.ParseString(xattribute16.Value);
      XAttribute xattribute17 = element.Attribute((XName) "parseddescription");
      if (xattribute17 != null)
        filearchiveSelect.parseddescription = ValueParser.ParseString(xattribute17.Value);
      XAttribute xattribute18 = element.Attribute((XName) "metadata");
      if (xattribute18 != null)
        filearchiveSelect.metadata = ValueParser.ParseString(xattribute18.Value);
      XAttribute xattribute19 = element.Attribute((XName) "bitdepth");
      if (xattribute19 != null && xattribute19.Value != "")
        filearchiveSelect.bitdepth = ValueParser.ParseInt32(xattribute19.Value);
      XAttribute xattribute20 = element.Attribute((XName) "mime");
      if (xattribute20 != null)
        filearchiveSelect.mime = ValueParser.ParseString(xattribute20.Value);
      XAttribute xattribute21 = element.Attribute((XName) "mediatype");
      if (xattribute21 != null)
        filearchiveSelect.mediatype = ValueParser.ParseString(xattribute21.Value);
      XAttribute xattribute22 = element.Attribute((XName) "archivename");
      if (xattribute22 != null)
        filearchiveSelect.archivename = ValueParser.ParseString(xattribute22.Value);
      return filearchiveSelect;
    }

    public override string ToString()
    {
      return string.Format("name: {0}; ns: {1}; title: {2}; filehidden: {3}; commenthidden: {4}; userhidden: {5}; suppressed: {6}; sha1: {7}; timestamp: {8}; userid: {9}; user: {10}; size: {11}; pagecount: {12}; height: {13}; width: {14}; description: {15}; parseddescription: {16}; metadata: {17}; bitdepth: {18}; mime: {19}; mediatype: {20}; archivename: {21}", (object) this.name, (object) this.ns, (object) this.title, (object) (bool) (this.filehidden ? 1 : 0), (object) (bool) (this.commenthidden ? 1 : 0), (object) (bool) (this.userhidden ? 1 : 0), (object) (bool) (this.suppressed ? 1 : 0), (object) this.sha1, (object) this.timestamp, (object) this.userid, (object) this.user, (object) this.size, (object) this.pagecount, (object) this.height, (object) this.width, (object) this.description, (object) this.parseddescription, (object) this.metadata, (object) this.bitdepth, (object) this.mime, (object) this.mediatype, (object) this.archivename);
    }
  }
}
