// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.categoryinfoResult
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class categoryinfoResult
  {
    public int size { get; private set; }

    public int pages { get; private set; }

    public int files { get; private set; }

    public int subcats { get; private set; }

    public bool hidden { get; private set; }

    private categoryinfoResult()
    {
    }

    public static categoryinfoResult Parse(XElement element, WikiInfo wiki)
    {
      categoryinfoResult categoryinfoResult = new categoryinfoResult();
      XAttribute xattribute1 = element.Attribute((XName) "size");
      if (xattribute1 != null && xattribute1.Value != "")
        categoryinfoResult.size = ValueParser.ParseInt32(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "pages");
      if (xattribute2 != null && xattribute2.Value != "")
        categoryinfoResult.pages = ValueParser.ParseInt32(xattribute2.Value);
      XAttribute xattribute3 = element.Attribute((XName) "files");
      if (xattribute3 != null && xattribute3.Value != "")
        categoryinfoResult.files = ValueParser.ParseInt32(xattribute3.Value);
      XAttribute xattribute4 = element.Attribute((XName) "subcats");
      if (xattribute4 != null && xattribute4.Value != "")
        categoryinfoResult.subcats = ValueParser.ParseInt32(xattribute4.Value);
      XAttribute xattribute5 = element.Attribute((XName) "hidden");
      if (xattribute5 != null)
        categoryinfoResult.hidden = ValueParser.ParseBoolean(xattribute5.Value);
      return categoryinfoResult;
    }

    public override string ToString()
    {
      return string.Format("size: {0}; pages: {1}; files: {2}; subcats: {3}; hidden: {4}", (object) this.size, (object) this.pages, (object) this.files, (object) this.subcats, (object) (bool) (this.hidden ? 1 : 0));
    }
  }
}
