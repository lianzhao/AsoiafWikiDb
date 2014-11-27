// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.undeleteResult
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class undeleteResult
  {
    public string title { get; private set; }

    public int revisions { get; private set; }

    public int filerevisions { get; private set; }

    public string reason { get; private set; }

    private undeleteResult()
    {
    }

    public static undeleteResult Parse(XElement element, WikiInfo wiki)
    {
      undeleteResult undeleteResult = new undeleteResult();
      XAttribute xattribute1 = element.Attribute((XName) "title");
      if (xattribute1 != null)
        undeleteResult.title = ValueParser.ParseString(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "revisions");
      if (xattribute2 != null && xattribute2.Value != "")
        undeleteResult.revisions = ValueParser.ParseInt32(xattribute2.Value);
      XAttribute xattribute3 = element.Attribute((XName) "filerevisions");
      if (xattribute3 != null && xattribute3.Value != "")
        undeleteResult.filerevisions = ValueParser.ParseInt32(xattribute3.Value);
      XAttribute xattribute4 = element.Attribute((XName) "reason");
      if (xattribute4 != null)
        undeleteResult.reason = ValueParser.ParseString(xattribute4.Value);
      return undeleteResult;
    }

    public override string ToString()
    {
      return string.Format("title: {0}; revisions: {1}; filerevisions: {2}; reason: {3}", (object) this.title, (object) this.revisions, (object) this.filerevisions, (object) this.reason);
    }
  }
}
