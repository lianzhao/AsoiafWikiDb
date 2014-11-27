// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.deleteglobalaccountResult
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class deleteglobalaccountResult
  {
    public string user { get; private set; }

    public string reason { get; private set; }

    private deleteglobalaccountResult()
    {
    }

    public static deleteglobalaccountResult Parse(XElement element, WikiInfo wiki)
    {
      deleteglobalaccountResult deleteglobalaccountResult = new deleteglobalaccountResult();
      XAttribute xattribute1 = element.Attribute((XName) "user");
      if (xattribute1 != null)
        deleteglobalaccountResult.user = ValueParser.ParseString(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "reason");
      if (xattribute2 != null)
        deleteglobalaccountResult.reason = ValueParser.ParseString(xattribute2.Value);
      return deleteglobalaccountResult;
    }

    public override string ToString()
    {
      return string.Format("user: {0}; reason: {1}", (object) this.user, (object) this.reason);
    }
  }
}
