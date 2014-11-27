// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.userinfoResult
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;
using System;
using System.Linq;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class userinfoResult
  {
    public long id { get; private set; }

    public string name { get; private set; }

    public bool anon { get; private set; }

    public long? blockid { get; private set; }

    public string blockedby { get; private set; }

    public long? blockedbyid { get; private set; }

    public string blockedreason { get; private set; }

    public bool messages { get; private set; }

    public string preferencestoken { get; private set; }

    public int editcount { get; private set; }

    public string realname { get; private set; }

    public string email { get; private set; }

    public DateTime? emailauthenticated { get; private set; }

    public DateTime? registrationdate { get; private set; }

    private userinfoResult()
    {
    }

    public static userinfoResult Parse(XElement element, WikiInfo wiki)
    {
      element = Enumerable.Single<XElement>(element.Elements());
      userinfoResult userinfoResult = new userinfoResult();
      XAttribute xattribute1 = element.Attribute((XName) "id");
      if (xattribute1 != null && xattribute1.Value != "")
        userinfoResult.id = ValueParser.ParseInt64(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "name");
      if (xattribute2 != null)
        userinfoResult.name = ValueParser.ParseString(xattribute2.Value);
      XAttribute xattribute3 = element.Attribute((XName) "anon");
      if (xattribute3 != null)
        userinfoResult.anon = ValueParser.ParseBoolean(xattribute3.Value);
      XAttribute xattribute4 = element.Attribute((XName) "blockid");
      if (xattribute4 != null && xattribute4.Value != "")
        userinfoResult.blockid = new long?(ValueParser.ParseInt64(xattribute4.Value));
      XAttribute xattribute5 = element.Attribute((XName) "blockedby");
      if (xattribute5 != null)
        userinfoResult.blockedby = ValueParser.ParseString(xattribute5.Value);
      XAttribute xattribute6 = element.Attribute((XName) "blockedbyid");
      if (xattribute6 != null && xattribute6.Value != "")
        userinfoResult.blockedbyid = new long?(ValueParser.ParseInt64(xattribute6.Value));
      XAttribute xattribute7 = element.Attribute((XName) "blockedreason");
      if (xattribute7 != null)
        userinfoResult.blockedreason = ValueParser.ParseString(xattribute7.Value);
      XAttribute xattribute8 = element.Attribute((XName) "messages");
      if (xattribute8 != null)
        userinfoResult.messages = ValueParser.ParseBoolean(xattribute8.Value);
      XAttribute xattribute9 = element.Attribute((XName) "preferencestoken");
      if (xattribute9 != null)
        userinfoResult.preferencestoken = ValueParser.ParseString(xattribute9.Value);
      XAttribute xattribute10 = element.Attribute((XName) "editcount");
      if (xattribute10 != null && xattribute10.Value != "")
        userinfoResult.editcount = ValueParser.ParseInt32(xattribute10.Value);
      XAttribute xattribute11 = element.Attribute((XName) "realname");
      if (xattribute11 != null)
        userinfoResult.realname = ValueParser.ParseString(xattribute11.Value);
      XAttribute xattribute12 = element.Attribute((XName) "email");
      if (xattribute12 != null)
        userinfoResult.email = ValueParser.ParseString(xattribute12.Value);
      XAttribute xattribute13 = element.Attribute((XName) "emailauthenticated");
      if (xattribute13 != null && xattribute13.Value != "")
        userinfoResult.emailauthenticated = new DateTime?(ValueParser.ParseDateTime(xattribute13.Value));
      XAttribute xattribute14 = element.Attribute((XName) "registrationdate");
      if (xattribute14 != null && xattribute14.Value != "")
        userinfoResult.registrationdate = new DateTime?(ValueParser.ParseDateTime(xattribute14.Value));
      return userinfoResult;
    }

    public override string ToString()
    {
      return string.Format("id: {0}; name: {1}; anon: {2}; blockid: {3}; blockedby: {4}; blockedbyid: {5}; blockedreason: {6}; messages: {7}; preferencestoken: {8}; editcount: {9}; realname: {10}; email: {11}; emailauthenticated: {12}; registrationdate: {13}", (object) this.id, (object) this.name, (object) (bool) (this.anon ? 1 : 0), (object) this.blockid, (object) this.blockedby, (object) this.blockedbyid, (object) this.blockedreason, (object) (bool) (this.messages ? 1 : 0), (object) this.preferencestoken, (object) this.editcount, (object) this.realname, (object) this.email, (object) this.emailauthenticated, (object) this.registrationdate);
    }
  }
}
