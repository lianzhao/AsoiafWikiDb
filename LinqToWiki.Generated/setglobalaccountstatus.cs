// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.setglobalaccountstatusResult
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Generated;
using LinqToWiki.Internals;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class setglobalaccountstatusResult
  {
    public string user { get; private set; }

    public bool locked { get; private set; }

    public setglobalaccountstatushidden hidden { get; private set; }

    public string reason { get; private set; }

    private setglobalaccountstatusResult()
    {
    }

    public static setglobalaccountstatusResult Parse(XElement element, WikiInfo wiki)
    {
      setglobalaccountstatusResult setglobalaccountstatusResult = new setglobalaccountstatusResult();
      XAttribute xattribute1 = element.Attribute((XName) "user");
      if (xattribute1 != null)
        setglobalaccountstatusResult.user = ValueParser.ParseString(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "locked");
      if (xattribute2 != null)
        setglobalaccountstatusResult.locked = ValueParser.ParseBoolean(xattribute2.Value);
      XAttribute xattribute3 = element.Attribute((XName) "hidden");
      if (xattribute3 != null && xattribute3.Value != "")
        setglobalaccountstatusResult.hidden = new setglobalaccountstatushidden(xattribute3.Value);
      XAttribute xattribute4 = element.Attribute((XName) "reason");
      if (xattribute4 != null)
        setglobalaccountstatusResult.reason = ValueParser.ParseString(xattribute4.Value);
      return setglobalaccountstatusResult;
    }

    public override string ToString()
    {
      return string.Format("user: {0}; locked: {1}; hidden: {2}; reason: {3}", (object) this.user, (object) (bool) (this.locked ? 1 : 0), (object) this.hidden, (object) this.reason);
    }
  }
}
