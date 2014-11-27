// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.optionsResult
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Generated;
using LinqToWiki.Internals;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class optionsResult
  {
    public optionsvalue value { get; private set; }

    private optionsResult()
    {
    }

    public static optionsResult Parse(XElement element, WikiInfo wiki)
    {
      optionsResult optionsResult = new optionsResult();
      XElement xelement = element;
      optionsResult.value = new optionsvalue(xelement.Value);
      return optionsResult;
    }

    public override string ToString()
    {
      return string.Format("value: {0}", (object) this.value);
    }
  }
}
