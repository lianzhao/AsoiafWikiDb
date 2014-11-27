// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.emailuserResult
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Generated;
using LinqToWiki.Internals;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class emailuserResult
  {
    public emailuserresult result { get; private set; }

    public string message { get; private set; }

    private emailuserResult()
    {
    }

    public static emailuserResult Parse(XElement element, WikiInfo wiki)
    {
      emailuserResult emailuserResult = new emailuserResult();
      XAttribute xattribute1 = element.Attribute((XName) "result");
      if (xattribute1 != null && xattribute1.Value != "")
        emailuserResult.result = new emailuserresult(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "message");
      if (xattribute2 != null)
        emailuserResult.message = ValueParser.ParseString(xattribute2.Value);
      return emailuserResult;
    }

    public override string ToString()
    {
      return string.Format("result: {0}; message: {1}", (object) this.result, (object) this.message);
    }
  }
}
