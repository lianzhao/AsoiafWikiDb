// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.compareResult
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class compareResult
  {
    public string fromtitle { get; private set; }

    public long fromrevid { get; private set; }

    public string totitle { get; private set; }

    public long torevid { get; private set; }

    public string value { get; private set; }

    private compareResult()
    {
    }

    public static compareResult Parse(XElement element, WikiInfo wiki)
    {
      compareResult compareResult = new compareResult();
      XAttribute xattribute1 = element.Attribute((XName) "fromtitle");
      if (xattribute1 != null)
        compareResult.fromtitle = ValueParser.ParseString(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "fromrevid");
      if (xattribute2 != null && xattribute2.Value != "")
        compareResult.fromrevid = ValueParser.ParseInt64(xattribute2.Value);
      XAttribute xattribute3 = element.Attribute((XName) "totitle");
      if (xattribute3 != null)
        compareResult.totitle = ValueParser.ParseString(xattribute3.Value);
      XAttribute xattribute4 = element.Attribute((XName) "torevid");
      if (xattribute4 != null && xattribute4.Value != "")
        compareResult.torevid = ValueParser.ParseInt64(xattribute4.Value);
      XElement xelement = element;
      compareResult.value = ValueParser.ParseString(xelement.Value);
      return compareResult;
    }

    public override string ToString()
    {
      return string.Format("fromtitle: {0}; fromrevid: {1}; totitle: {2}; torevid: {3}; value: {4}", (object) this.fromtitle, (object) this.fromrevid, (object) this.totitle, (object) this.torevid, (object) this.value);
    }
  }
}
