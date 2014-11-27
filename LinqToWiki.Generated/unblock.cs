// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.unblockResult
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class unblockResult
  {
    public long? id { get; private set; }

    public string user { get; private set; }

    public long? userid { get; private set; }

    public string reason { get; private set; }

    private unblockResult()
    {
    }

    public static unblockResult Parse(XElement element, WikiInfo wiki)
    {
      unblockResult unblockResult = new unblockResult();
      XAttribute xattribute1 = element.Attribute((XName) "id");
      if (xattribute1 != null && xattribute1.Value != "")
        unblockResult.id = new long?(ValueParser.ParseInt64(xattribute1.Value));
      XAttribute xattribute2 = element.Attribute((XName) "user");
      if (xattribute2 != null)
        unblockResult.user = ValueParser.ParseString(xattribute2.Value);
      XAttribute xattribute3 = element.Attribute((XName) "userid");
      if (xattribute3 != null && xattribute3.Value != "")
        unblockResult.userid = new long?(ValueParser.ParseInt64(xattribute3.Value));
      XAttribute xattribute4 = element.Attribute((XName) "reason");
      if (xattribute4 != null)
        unblockResult.reason = ValueParser.ParseString(xattribute4.Value);
      return unblockResult;
    }

    public override string ToString()
    {
      return string.Format("id: {0}; user: {1}; userid: {2}; reason: {3}", (object) this.id, (object) this.user, (object) this.userid, (object) this.reason);
    }
  }
}
