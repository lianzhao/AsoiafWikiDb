// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.allusersSelect
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class allusersSelect
  {
    public long userid { get; private set; }

    public string name { get; private set; }

    public int? recenteditcount { get; private set; }

    public long? blockid { get; private set; }

    public string blockedby { get; private set; }

    public long? blockedbyid { get; private set; }

    public string blockedreason { get; private set; }

    public string blockedexpiry { get; private set; }

    public bool hidden { get; private set; }

    public int editcount { get; private set; }

    public string registration { get; private set; }

    private allusersSelect()
    {
    }

    public static allusersSelect Parse(XElement element, WikiInfo wiki)
    {
      allusersSelect allusersSelect = new allusersSelect();
      XAttribute xattribute1 = element.Attribute((XName) "userid");
      if (xattribute1 != null && xattribute1.Value != "")
        allusersSelect.userid = ValueParser.ParseInt64(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "name");
      if (xattribute2 != null)
        allusersSelect.name = ValueParser.ParseString(xattribute2.Value);
      XAttribute xattribute3 = element.Attribute((XName) "recenteditcount");
      if (xattribute3 != null && xattribute3.Value != "")
        allusersSelect.recenteditcount = new int?(ValueParser.ParseInt32(xattribute3.Value));
      XAttribute xattribute4 = element.Attribute((XName) "blockid");
      if (xattribute4 != null && xattribute4.Value != "")
        allusersSelect.blockid = new long?(ValueParser.ParseInt64(xattribute4.Value));
      XAttribute xattribute5 = element.Attribute((XName) "blockedby");
      if (xattribute5 != null)
        allusersSelect.blockedby = ValueParser.ParseString(xattribute5.Value);
      XAttribute xattribute6 = element.Attribute((XName) "blockedbyid");
      if (xattribute6 != null && xattribute6.Value != "")
        allusersSelect.blockedbyid = new long?(ValueParser.ParseInt64(xattribute6.Value));
      XAttribute xattribute7 = element.Attribute((XName) "blockedreason");
      if (xattribute7 != null)
        allusersSelect.blockedreason = ValueParser.ParseString(xattribute7.Value);
      XAttribute xattribute8 = element.Attribute((XName) "blockedexpiry");
      if (xattribute8 != null)
        allusersSelect.blockedexpiry = ValueParser.ParseString(xattribute8.Value);
      XAttribute xattribute9 = element.Attribute((XName) "hidden");
      if (xattribute9 != null)
        allusersSelect.hidden = ValueParser.ParseBoolean(xattribute9.Value);
      XAttribute xattribute10 = element.Attribute((XName) "editcount");
      if (xattribute10 != null && xattribute10.Value != "")
        allusersSelect.editcount = ValueParser.ParseInt32(xattribute10.Value);
      XAttribute xattribute11 = element.Attribute((XName) "registration");
      if (xattribute11 != null)
        allusersSelect.registration = ValueParser.ParseString(xattribute11.Value);
      return allusersSelect;
    }

    public override string ToString()
    {
      return string.Format("userid: {0}; name: {1}; recenteditcount: {2}; blockid: {3}; blockedby: {4}; blockedbyid: {5}; blockedreason: {6}; blockedexpiry: {7}; hidden: {8}; editcount: {9}; registration: {10}", (object) this.userid, (object) this.name, (object) this.recenteditcount, (object) this.blockid, (object) this.blockedby, (object) this.blockedbyid, (object) this.blockedreason, (object) this.blockedexpiry, (object) (bool) (this.hidden ? 1 : 0), (object) this.editcount, (object) this.registration);
    }
  }
}
