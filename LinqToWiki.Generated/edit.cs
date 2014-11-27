// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.editResult
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Generated;
using LinqToWiki.Internals;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class editResult
  {
    public bool @new { get; private set; }

    public editresult result { get; private set; }

    public long? pageid { get; private set; }

    public string title { get; private set; }

    public bool nochange { get; private set; }

    public long? oldrevid { get; private set; }

    public long? newrevid { get; private set; }

    public string newtimestamp { get; private set; }

    private editResult()
    {
    }

    public static editResult Parse(XElement element, WikiInfo wiki)
    {
      editResult editResult = new editResult();
      XAttribute xattribute1 = element.Attribute((XName) "new");
      if (xattribute1 != null)
        editResult.@new = ValueParser.ParseBoolean(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "result");
      if (xattribute2 != null && xattribute2.Value != "")
        editResult.result = new editresult(xattribute2.Value);
      XAttribute xattribute3 = element.Attribute((XName) "pageid");
      if (xattribute3 != null && xattribute3.Value != "")
        editResult.pageid = new long?(ValueParser.ParseInt64(xattribute3.Value));
      XAttribute xattribute4 = element.Attribute((XName) "title");
      if (xattribute4 != null)
        editResult.title = ValueParser.ParseString(xattribute4.Value);
      XAttribute xattribute5 = element.Attribute((XName) "nochange");
      if (xattribute5 != null)
        editResult.nochange = ValueParser.ParseBoolean(xattribute5.Value);
      XAttribute xattribute6 = element.Attribute((XName) "oldrevid");
      if (xattribute6 != null && xattribute6.Value != "")
        editResult.oldrevid = new long?(ValueParser.ParseInt64(xattribute6.Value));
      XAttribute xattribute7 = element.Attribute((XName) "newrevid");
      if (xattribute7 != null && xattribute7.Value != "")
        editResult.newrevid = new long?(ValueParser.ParseInt64(xattribute7.Value));
      XAttribute xattribute8 = element.Attribute((XName) "newtimestamp");
      if (xattribute8 != null)
        editResult.newtimestamp = ValueParser.ParseString(xattribute8.Value);
      return editResult;
    }

    public override string ToString()
    {
      return string.Format("new: {0}; result: {1}; pageid: {2}; title: {3}; nochange: {4}; oldrevid: {5}; newrevid: {6}; newtimestamp: {7}", (object) (bool) (this.@new ? 1 : 0), (object) this.result, (object) this.pageid, (object) this.title, (object) (bool) (this.nochange ? 1 : 0), (object) this.oldrevid, (object) this.newrevid, (object) this.newtimestamp);
    }
  }
}
