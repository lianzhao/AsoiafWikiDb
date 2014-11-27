// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.moveResult
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class moveResult
  {
    public string from { get; private set; }

    public string to { get; private set; }

    public string reason { get; private set; }

    public bool redirectcreated { get; private set; }

    public bool moveoverredirect { get; private set; }

    public string talkfrom { get; private set; }

    public string talkto { get; private set; }

    public bool talkmoveoverredirect { get; private set; }

    public string talkmove_error_code { get; private set; }

    public string talkmove_error_info { get; private set; }

    private moveResult()
    {
    }

    public static moveResult Parse(XElement element, WikiInfo wiki)
    {
      moveResult moveResult = new moveResult();
      XAttribute xattribute1 = element.Attribute((XName) "from");
      if (xattribute1 != null)
        moveResult.from = ValueParser.ParseString(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "to");
      if (xattribute2 != null)
        moveResult.to = ValueParser.ParseString(xattribute2.Value);
      XAttribute xattribute3 = element.Attribute((XName) "reason");
      if (xattribute3 != null)
        moveResult.reason = ValueParser.ParseString(xattribute3.Value);
      XAttribute xattribute4 = element.Attribute((XName) "redirectcreated");
      if (xattribute4 != null)
        moveResult.redirectcreated = ValueParser.ParseBoolean(xattribute4.Value);
      XAttribute xattribute5 = element.Attribute((XName) "moveoverredirect");
      if (xattribute5 != null)
        moveResult.moveoverredirect = ValueParser.ParseBoolean(xattribute5.Value);
      XAttribute xattribute6 = element.Attribute((XName) "talkfrom");
      if (xattribute6 != null)
        moveResult.talkfrom = ValueParser.ParseString(xattribute6.Value);
      XAttribute xattribute7 = element.Attribute((XName) "talkto");
      if (xattribute7 != null)
        moveResult.talkto = ValueParser.ParseString(xattribute7.Value);
      XAttribute xattribute8 = element.Attribute((XName) "talkmoveoverredirect");
      if (xattribute8 != null)
        moveResult.talkmoveoverredirect = ValueParser.ParseBoolean(xattribute8.Value);
      XAttribute xattribute9 = element.Attribute((XName) "talkmove-error-code");
      if (xattribute9 != null)
        moveResult.talkmove_error_code = ValueParser.ParseString(xattribute9.Value);
      XAttribute xattribute10 = element.Attribute((XName) "talkmove-error-info");
      if (xattribute10 != null)
        moveResult.talkmove_error_info = ValueParser.ParseString(xattribute10.Value);
      return moveResult;
    }

    public override string ToString()
    {
      return string.Format("from: {0}; to: {1}; reason: {2}; redirectcreated: {3}; moveoverredirect: {4}; talkfrom: {5}; talkto: {6}; talkmoveoverredirect: {7}; talkmove_error_code: {8}; talkmove_error_info: {9}", (object) this.from, (object) this.to, (object) this.reason, (object) (bool) (this.redirectcreated ? 1 : 0), (object) (bool) (this.moveoverredirect ? 1 : 0), (object) this.talkfrom, (object) this.talkto, (object) (bool) (this.talkmoveoverredirect ? 1 : 0), (object) this.talkmove_error_code, (object) this.talkmove_error_info);
    }
  }
}
