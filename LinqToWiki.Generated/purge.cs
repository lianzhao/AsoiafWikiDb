// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.purgeResult
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki;
using LinqToWiki.Internals;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class purgeResult
  {
    public Namespace ns { get; private set; }

    public string title { get; private set; }

    public long? pageid { get; private set; }

    public long? revid { get; private set; }

    public bool invalid { get; private set; }

    public bool special { get; private set; }

    public bool missing { get; private set; }

    public bool purged { get; private set; }

    public bool linkupdate { get; private set; }

    public string iw { get; private set; }

    private purgeResult()
    {
    }

    public static purgeResult Parse(XElement element, WikiInfo wiki)
    {
      purgeResult purgeResult = new purgeResult();
      XAttribute xattribute1 = element.Attribute((XName) "ns");
      if (xattribute1 != null && xattribute1.Value != "")
        purgeResult.ns = ValueParser.ParseNamespace(xattribute1.Value, wiki);
      XAttribute xattribute2 = element.Attribute((XName) "title");
      if (xattribute2 != null)
        purgeResult.title = ValueParser.ParseString(xattribute2.Value);
      XAttribute xattribute3 = element.Attribute((XName) "pageid");
      if (xattribute3 != null && xattribute3.Value != "")
        purgeResult.pageid = new long?(ValueParser.ParseInt64(xattribute3.Value));
      XAttribute xattribute4 = element.Attribute((XName) "revid");
      if (xattribute4 != null && xattribute4.Value != "")
        purgeResult.revid = new long?(ValueParser.ParseInt64(xattribute4.Value));
      XAttribute xattribute5 = element.Attribute((XName) "invalid");
      if (xattribute5 != null)
        purgeResult.invalid = ValueParser.ParseBoolean(xattribute5.Value);
      XAttribute xattribute6 = element.Attribute((XName) "special");
      if (xattribute6 != null)
        purgeResult.special = ValueParser.ParseBoolean(xattribute6.Value);
      XAttribute xattribute7 = element.Attribute((XName) "missing");
      if (xattribute7 != null)
        purgeResult.missing = ValueParser.ParseBoolean(xattribute7.Value);
      XAttribute xattribute8 = element.Attribute((XName) "purged");
      if (xattribute8 != null)
        purgeResult.purged = ValueParser.ParseBoolean(xattribute8.Value);
      XAttribute xattribute9 = element.Attribute((XName) "linkupdate");
      if (xattribute9 != null)
        purgeResult.linkupdate = ValueParser.ParseBoolean(xattribute9.Value);
      XAttribute xattribute10 = element.Attribute((XName) "iw");
      if (xattribute10 != null)
        purgeResult.iw = ValueParser.ParseString(xattribute10.Value);
      return purgeResult;
    }

    public override string ToString()
    {
      return string.Format("ns: {0}; title: {1}; pageid: {2}; revid: {3}; invalid: {4}; special: {5}; missing: {6}; purged: {7}; linkupdate: {8}; iw: {9}", (object) this.ns, (object) this.title, (object) this.pageid, (object) this.revid, (this.invalid ? 1 : 0), (this.special ? 1 : 0), (this.missing ? 1 : 0), (this.purged ? 1 : 0), (this.linkupdate ? 1 : 0), (object) this.iw);
    }
  }
}
