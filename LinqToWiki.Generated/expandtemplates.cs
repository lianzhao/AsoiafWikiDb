// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.expandtemplatesResult
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class expandtemplatesResult
  {
    public string value { get; private set; }

    private expandtemplatesResult()
    {
    }

    public static expandtemplatesResult Parse(XElement element, WikiInfo wiki)
    {
      expandtemplatesResult expandtemplatesResult = new expandtemplatesResult();
      XElement xelement = element;
      expandtemplatesResult.value = ValueParser.ParseString(xelement.Value);
      return expandtemplatesResult;
    }

    public override string ToString()
    {
      return string.Format("value: {0}", (object) this.value);
    }
  }
}
