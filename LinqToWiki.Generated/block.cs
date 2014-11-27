// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.blockResult
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class blockResult
  {
    public string user { get; private set; }

    public int? userID { get; private set; }

    public string expiry { get; private set; }

    public long? id { get; private set; }

    public string reason { get; private set; }

    public bool anononly { get; private set; }

    public bool nocreate { get; private set; }

    public bool autoblock { get; private set; }

    public bool noemail { get; private set; }

    public bool hidename { get; private set; }

    public bool allowusertalk { get; private set; }

    public bool watchuser { get; private set; }

    private blockResult()
    {
    }

    public static blockResult Parse(XElement element, WikiInfo wiki)
    {
      blockResult blockResult = new blockResult();
      XAttribute xattribute1 = element.Attribute((XName) "user");
      if (xattribute1 != null)
        blockResult.user = ValueParser.ParseString(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "userID");
      if (xattribute2 != null && xattribute2.Value != "")
        blockResult.userID = new int?(ValueParser.ParseInt32(xattribute2.Value));
      XAttribute xattribute3 = element.Attribute((XName) "expiry");
      if (xattribute3 != null)
        blockResult.expiry = ValueParser.ParseString(xattribute3.Value);
      XAttribute xattribute4 = element.Attribute((XName) "id");
      if (xattribute4 != null && xattribute4.Value != "")
        blockResult.id = new long?(ValueParser.ParseInt64(xattribute4.Value));
      XAttribute xattribute5 = element.Attribute((XName) "reason");
      if (xattribute5 != null)
        blockResult.reason = ValueParser.ParseString(xattribute5.Value);
      XAttribute xattribute6 = element.Attribute((XName) "anononly");
      if (xattribute6 != null)
        blockResult.anononly = ValueParser.ParseBoolean(xattribute6.Value);
      XAttribute xattribute7 = element.Attribute((XName) "nocreate");
      if (xattribute7 != null)
        blockResult.nocreate = ValueParser.ParseBoolean(xattribute7.Value);
      XAttribute xattribute8 = element.Attribute((XName) "autoblock");
      if (xattribute8 != null)
        blockResult.autoblock = ValueParser.ParseBoolean(xattribute8.Value);
      XAttribute xattribute9 = element.Attribute((XName) "noemail");
      if (xattribute9 != null)
        blockResult.noemail = ValueParser.ParseBoolean(xattribute9.Value);
      XAttribute xattribute10 = element.Attribute((XName) "hidename");
      if (xattribute10 != null)
        blockResult.hidename = ValueParser.ParseBoolean(xattribute10.Value);
      XAttribute xattribute11 = element.Attribute((XName) "allowusertalk");
      if (xattribute11 != null)
        blockResult.allowusertalk = ValueParser.ParseBoolean(xattribute11.Value);
      XAttribute xattribute12 = element.Attribute((XName) "watchuser");
      if (xattribute12 != null)
        blockResult.watchuser = ValueParser.ParseBoolean(xattribute12.Value);
      return blockResult;
    }

    public override string ToString()
    {
      return string.Format("user: {0}; userID: {1}; expiry: {2}; id: {3}; reason: {4}; anononly: {5}; nocreate: {6}; autoblock: {7}; noemail: {8}; hidename: {9}; allowusertalk: {10}; watchuser: {11}", (object) this.user, (object) this.userID, (object) this.expiry, (object) this.id, (object) this.reason, (this.anononly ? 1 : 0), (this.nocreate ? 1 : 0), (this.autoblock ? 1 : 0), (this.noemail ? 1 : 0), (this.hidename ? 1 : 0), (this.allowusertalk ? 1 : 0), (this.watchuser ? 1 : 0));
    }
  }
}
