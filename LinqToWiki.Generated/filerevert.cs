// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.filerevertResult
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Generated;
using LinqToWiki.Internals;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class filerevertResult
  {
    public filerevertresult result { get; private set; }

    public string errors { get; private set; }

    private filerevertResult()
    {
    }

    public static filerevertResult Parse(XElement element, WikiInfo wiki)
    {
      filerevertResult filerevertResult = new filerevertResult();
      XAttribute xattribute1 = element.Attribute((XName) "result");
      if (xattribute1 != null && xattribute1.Value != "")
        filerevertResult.result = new filerevertresult(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "errors");
      if (xattribute2 != null)
        filerevertResult.errors = ValueParser.ParseString(xattribute2.Value);
      return filerevertResult;
    }

    public override string ToString()
    {
      return string.Format("result: {0}; errors: {1}", (object) this.result, (object) this.errors);
    }
  }
}
