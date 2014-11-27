// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.uploadResult
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Generated;
using LinqToWiki.Internals;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class uploadResult
  {
    public uploadresult result { get; private set; }

    public string filekey { get; private set; }

    public string sessionkey { get; private set; }

    public int? offset { get; private set; }

    public string statuskey { get; private set; }

    public string filename { get; private set; }

    private uploadResult()
    {
    }

    public static uploadResult Parse(XElement element, WikiInfo wiki)
    {
      uploadResult uploadResult = new uploadResult();
      XAttribute xattribute1 = element.Attribute((XName) "result");
      if (xattribute1 != null && xattribute1.Value != "")
        uploadResult.result = new uploadresult(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "filekey");
      if (xattribute2 != null)
        uploadResult.filekey = ValueParser.ParseString(xattribute2.Value);
      XAttribute xattribute3 = element.Attribute((XName) "sessionkey");
      if (xattribute3 != null)
        uploadResult.sessionkey = ValueParser.ParseString(xattribute3.Value);
      XAttribute xattribute4 = element.Attribute((XName) "offset");
      if (xattribute4 != null && xattribute4.Value != "")
        uploadResult.offset = new int?(ValueParser.ParseInt32(xattribute4.Value));
      XAttribute xattribute5 = element.Attribute((XName) "statuskey");
      if (xattribute5 != null)
        uploadResult.statuskey = ValueParser.ParseString(xattribute5.Value);
      XAttribute xattribute6 = element.Attribute((XName) "filename");
      if (xattribute6 != null)
        uploadResult.filename = ValueParser.ParseString(xattribute6.Value);
      return uploadResult;
    }

    public override string ToString()
    {
      return string.Format("result: {0}; filekey: {1}; sessionkey: {2}; offset: {3}; statuskey: {4}; filename: {5}", (object) this.result, (object) this.filekey, (object) this.sessionkey, (object) this.offset, (object) this.statuskey, (object) this.filename);
    }
  }
}
