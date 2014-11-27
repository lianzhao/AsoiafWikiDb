// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.usersSelect
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Generated;
using LinqToWiki.Internals;
using System;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class usersSelect
  {
    public long? userid { get; private set; }

    public string name { get; private set; }

    public bool invalid { get; private set; }

    public bool hidden { get; private set; }

    public bool interwiki { get; private set; }

    public bool missing { get; private set; }

    public string userrightstoken { get; private set; }

    public int? editcount { get; private set; }

    public DateTime? registration { get; private set; }

    public long? blockid { get; private set; }

    public string blockedby { get; private set; }

    public long? blockedbyid { get; private set; }

    public string blockedreason { get; private set; }

    public DateTime? blockedexpiry { get; private set; }

    public bool emailable { get; private set; }

    public usersgender gender { get; private set; }

    private usersSelect()
    {
    }

    public static usersSelect Parse(XElement element, WikiInfo wiki)
    {
      usersSelect usersSelect = new usersSelect();
      XAttribute xattribute1 = element.Attribute((XName) "userid");
      if (xattribute1 != null && xattribute1.Value != "")
        usersSelect.userid = new long?(ValueParser.ParseInt64(xattribute1.Value));
      XAttribute xattribute2 = element.Attribute((XName) "name");
      if (xattribute2 != null)
        usersSelect.name = ValueParser.ParseString(xattribute2.Value);
      XAttribute xattribute3 = element.Attribute((XName) "invalid");
      if (xattribute3 != null)
        usersSelect.invalid = ValueParser.ParseBoolean(xattribute3.Value);
      XAttribute xattribute4 = element.Attribute((XName) "hidden");
      if (xattribute4 != null)
        usersSelect.hidden = ValueParser.ParseBoolean(xattribute4.Value);
      XAttribute xattribute5 = element.Attribute((XName) "interwiki");
      if (xattribute5 != null)
        usersSelect.interwiki = ValueParser.ParseBoolean(xattribute5.Value);
      XAttribute xattribute6 = element.Attribute((XName) "missing");
      if (xattribute6 != null)
        usersSelect.missing = ValueParser.ParseBoolean(xattribute6.Value);
      XAttribute xattribute7 = element.Attribute((XName) "userrightstoken");
      if (xattribute7 != null)
        usersSelect.userrightstoken = ValueParser.ParseString(xattribute7.Value);
      XAttribute xattribute8 = element.Attribute((XName) "editcount");
      if (xattribute8 != null && xattribute8.Value != "")
        usersSelect.editcount = new int?(ValueParser.ParseInt32(xattribute8.Value));
      XAttribute xattribute9 = element.Attribute((XName) "registration");
      if (xattribute9 != null && xattribute9.Value != "")
        usersSelect.registration = new DateTime?(ValueParser.ParseDateTime(xattribute9.Value));
      XAttribute xattribute10 = element.Attribute((XName) "blockid");
      if (xattribute10 != null && xattribute10.Value != "")
        usersSelect.blockid = new long?(ValueParser.ParseInt64(xattribute10.Value));
      XAttribute xattribute11 = element.Attribute((XName) "blockedby");
      if (xattribute11 != null)
        usersSelect.blockedby = ValueParser.ParseString(xattribute11.Value);
      XAttribute xattribute12 = element.Attribute((XName) "blockedbyid");
      if (xattribute12 != null && xattribute12.Value != "")
        usersSelect.blockedbyid = new long?(ValueParser.ParseInt64(xattribute12.Value));
      XAttribute xattribute13 = element.Attribute((XName) "blockedreason");
      if (xattribute13 != null)
        usersSelect.blockedreason = ValueParser.ParseString(xattribute13.Value);
      XAttribute xattribute14 = element.Attribute((XName) "blockedexpiry");
      if (xattribute14 != null && xattribute14.Value != "")
        usersSelect.blockedexpiry = new DateTime?(ValueParser.ParseDateTime(xattribute14.Value));
      XAttribute xattribute15 = element.Attribute((XName) "emailable");
      if (xattribute15 != null)
        usersSelect.emailable = ValueParser.ParseBoolean(xattribute15.Value);
      XAttribute xattribute16 = element.Attribute((XName) "gender");
      if (xattribute16 != null && xattribute16.Value != "")
        usersSelect.gender = new usersgender(xattribute16.Value);
      return usersSelect;
    }

    public override string ToString()
    {
      return string.Format("userid: {0}; name: {1}; invalid: {2}; hidden: {3}; interwiki: {4}; missing: {5}; userrightstoken: {6}; editcount: {7}; registration: {8}; blockid: {9}; blockedby: {10}; blockedbyid: {11}; blockedreason: {12}; blockedexpiry: {13}; emailable: {14}; gender: {15}", (object) this.userid, (object) this.name, (object) (bool) (this.invalid ? 1 : 0), (object) (bool) (this.hidden ? 1 : 0), (object) (bool) (this.interwiki ? 1 : 0), (object) (bool) (this.missing ? 1 : 0), (object) this.userrightstoken, (object) this.editcount, (object) this.registration, (object) this.blockid, (object) this.blockedby, (object) this.blockedbyid, (object) this.blockedreason, (object) this.blockedexpiry, (object) (bool) (this.emailable ? 1 : 0), (object) this.gender);
    }
  }
}
