// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.rollbackResult
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class rollbackResult
  {
    public string title { get; private set; }

    public long pageid { get; private set; }

    public string summary { get; private set; }

    public long revid { get; private set; }

    public long old_revid { get; private set; }

    public long last_revid { get; private set; }

    private rollbackResult()
    {
    }

    public static rollbackResult Parse(XElement element, WikiInfo wiki)
    {
      rollbackResult rollbackResult = new rollbackResult();
      XAttribute xattribute1 = element.Attribute((XName) "title");
      if (xattribute1 != null)
        rollbackResult.title = ValueParser.ParseString(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "pageid");
      if (xattribute2 != null && xattribute2.Value != "")
        rollbackResult.pageid = ValueParser.ParseInt64(xattribute2.Value);
      XAttribute xattribute3 = element.Attribute((XName) "summary");
      if (xattribute3 != null)
        rollbackResult.summary = ValueParser.ParseString(xattribute3.Value);
      XAttribute xattribute4 = element.Attribute((XName) "revid");
      if (xattribute4 != null && xattribute4.Value != "")
        rollbackResult.revid = ValueParser.ParseInt64(xattribute4.Value);
      XAttribute xattribute5 = element.Attribute((XName) "old_revid");
      if (xattribute5 != null && xattribute5.Value != "")
        rollbackResult.old_revid = ValueParser.ParseInt64(xattribute5.Value);
      XAttribute xattribute6 = element.Attribute((XName) "last_revid");
      if (xattribute6 != null && xattribute6.Value != "")
        rollbackResult.last_revid = ValueParser.ParseInt64(xattribute6.Value);
      return rollbackResult;
    }

    public override string ToString()
    {
      return string.Format("title: {0}; pageid: {1}; summary: {2}; revid: {3}; old_revid: {4}; last_revid: {5}", (object) this.title, (object) this.pageid, (object) this.summary, (object) this.revid, (object) this.old_revid, (object) this.last_revid);
    }
  }
}
