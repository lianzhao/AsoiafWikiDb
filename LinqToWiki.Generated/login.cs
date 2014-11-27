// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.loginResult
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Generated;
using LinqToWiki.Internals;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class loginResult
  {
    public loginresult result { get; private set; }

    public long? lguserid { get; private set; }

    public string lgusername { get; private set; }

    public string lgtoken { get; private set; }

    public string cookieprefix { get; private set; }

    public string sessionid { get; private set; }

    public string token { get; private set; }

    public string details { get; private set; }

    public int? wait { get; private set; }

    public string reason { get; private set; }

    private loginResult()
    {
    }

    public static loginResult Parse(XElement element, WikiInfo wiki)
    {
      loginResult loginResult = new loginResult();
      XAttribute xattribute1 = element.Attribute((XName) "result");
      if (xattribute1 != null && xattribute1.Value != "")
        loginResult.result = new loginresult(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "lguserid");
      if (xattribute2 != null && xattribute2.Value != "")
        loginResult.lguserid = new long?(ValueParser.ParseInt64(xattribute2.Value));
      XAttribute xattribute3 = element.Attribute((XName) "lgusername");
      if (xattribute3 != null)
        loginResult.lgusername = ValueParser.ParseString(xattribute3.Value);
      XAttribute xattribute4 = element.Attribute((XName) "lgtoken");
      if (xattribute4 != null)
        loginResult.lgtoken = ValueParser.ParseString(xattribute4.Value);
      XAttribute xattribute5 = element.Attribute((XName) "cookieprefix");
      if (xattribute5 != null)
        loginResult.cookieprefix = ValueParser.ParseString(xattribute5.Value);
      XAttribute xattribute6 = element.Attribute((XName) "sessionid");
      if (xattribute6 != null)
        loginResult.sessionid = ValueParser.ParseString(xattribute6.Value);
      XAttribute xattribute7 = element.Attribute((XName) "token");
      if (xattribute7 != null)
        loginResult.token = ValueParser.ParseString(xattribute7.Value);
      XAttribute xattribute8 = element.Attribute((XName) "details");
      if (xattribute8 != null)
        loginResult.details = ValueParser.ParseString(xattribute8.Value);
      XAttribute xattribute9 = element.Attribute((XName) "wait");
      if (xattribute9 != null && xattribute9.Value != "")
        loginResult.wait = new int?(ValueParser.ParseInt32(xattribute9.Value));
      XAttribute xattribute10 = element.Attribute((XName) "reason");
      if (xattribute10 != null)
        loginResult.reason = ValueParser.ParseString(xattribute10.Value);
      return loginResult;
    }

    public override string ToString()
    {
      return string.Format("result: {0}; lguserid: {1}; lgusername: {2}; lgtoken: {3}; cookieprefix: {4}; sessionid: {5}; token: {6}; details: {7}; wait: {8}; reason: {9}", (object) this.result, (object) this.lguserid, (object) this.lgusername, (object) this.lgtoken, (object) this.cookieprefix, (object) this.sessionid, (object) this.token, (object) this.details, (object) this.wait, (object) this.reason);
    }
  }
}
