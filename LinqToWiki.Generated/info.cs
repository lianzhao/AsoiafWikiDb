// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.infoResult
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki;
using LinqToWiki.Internals;
using System;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class infoResult
  {
    public long? pageid { get; private set; }

    public Namespace ns { get; private set; }

    public string title { get; private set; }

    public bool missing { get; private set; }

    public bool invalid { get; private set; }

    public bool special { get; private set; }

    public DateTime touched { get; private set; }

    public long lastrevid { get; private set; }

    public int? counter { get; private set; }

    public int length { get; private set; }

    public bool redirect { get; private set; }

    public bool @new { get; private set; }

    public DateTime? starttimestamp { get; private set; }

    public string contentmodel { get; private set; }

    public string edittoken { get; private set; }

    public string deletetoken { get; private set; }

    public string protecttoken { get; private set; }

    public string movetoken { get; private set; }

    public string blocktoken { get; private set; }

    public string unblocktoken { get; private set; }

    public string emailtoken { get; private set; }

    public string importtoken { get; private set; }

    public string watchtoken { get; private set; }

    public bool watched { get; private set; }

    public int? watchers { get; private set; }

    public DateTime? notificationtimestamp { get; private set; }

    public long? talkid { get; private set; }

    public long? subjectid { get; private set; }

    public string fullurl { get; private set; }

    public string editurl { get; private set; }

    public bool readable { get; private set; }

    public string preload { get; private set; }

    public string displaytitle { get; private set; }

    private infoResult()
    {
    }

    public static infoResult Parse(XElement element, WikiInfo wiki)
    {
      infoResult infoResult = new infoResult();
      XAttribute xattribute1 = element.Attribute((XName) "pageid");
      if (xattribute1 != null && xattribute1.Value != "")
        infoResult.pageid = new long?(ValueParser.ParseInt64(xattribute1.Value));
      XAttribute xattribute2 = element.Attribute((XName) "ns");
      if (xattribute2 != null && xattribute2.Value != "")
        infoResult.ns = ValueParser.ParseNamespace(xattribute2.Value, wiki);
      XAttribute xattribute3 = element.Attribute((XName) "title");
      if (xattribute3 != null)
        infoResult.title = ValueParser.ParseString(xattribute3.Value);
      XAttribute xattribute4 = element.Attribute((XName) "missing");
      if (xattribute4 != null)
        infoResult.missing = ValueParser.ParseBoolean(xattribute4.Value);
      XAttribute xattribute5 = element.Attribute((XName) "invalid");
      if (xattribute5 != null)
        infoResult.invalid = ValueParser.ParseBoolean(xattribute5.Value);
      XAttribute xattribute6 = element.Attribute((XName) "special");
      if (xattribute6 != null)
        infoResult.special = ValueParser.ParseBoolean(xattribute6.Value);
      XAttribute xattribute7 = element.Attribute((XName) "touched");
      if (xattribute7 != null && xattribute7.Value != "")
        infoResult.touched = ValueParser.ParseDateTime(xattribute7.Value);
      XAttribute xattribute8 = element.Attribute((XName) "lastrevid");
      if (xattribute8 != null && xattribute8.Value != "")
        infoResult.lastrevid = ValueParser.ParseInt64(xattribute8.Value);
      XAttribute xattribute9 = element.Attribute((XName) "counter");
      if (xattribute9 != null && xattribute9.Value != "")
        infoResult.counter = new int?(ValueParser.ParseInt32(xattribute9.Value));
      XAttribute xattribute10 = element.Attribute((XName) "length");
      if (xattribute10 != null && xattribute10.Value != "")
        infoResult.length = ValueParser.ParseInt32(xattribute10.Value);
      XAttribute xattribute11 = element.Attribute((XName) "redirect");
      if (xattribute11 != null)
        infoResult.redirect = ValueParser.ParseBoolean(xattribute11.Value);
      XAttribute xattribute12 = element.Attribute((XName) "new");
      if (xattribute12 != null)
        infoResult.@new = ValueParser.ParseBoolean(xattribute12.Value);
      XAttribute xattribute13 = element.Attribute((XName) "starttimestamp");
      if (xattribute13 != null && xattribute13.Value != "")
        infoResult.starttimestamp = new DateTime?(ValueParser.ParseDateTime(xattribute13.Value));
      XAttribute xattribute14 = element.Attribute((XName) "contentmodel");
      if (xattribute14 != null)
        infoResult.contentmodel = ValueParser.ParseString(xattribute14.Value);
      XAttribute xattribute15 = element.Attribute((XName) "edittoken");
      if (xattribute15 != null)
        infoResult.edittoken = ValueParser.ParseString(xattribute15.Value);
      XAttribute xattribute16 = element.Attribute((XName) "deletetoken");
      if (xattribute16 != null)
        infoResult.deletetoken = ValueParser.ParseString(xattribute16.Value);
      XAttribute xattribute17 = element.Attribute((XName) "protecttoken");
      if (xattribute17 != null)
        infoResult.protecttoken = ValueParser.ParseString(xattribute17.Value);
      XAttribute xattribute18 = element.Attribute((XName) "movetoken");
      if (xattribute18 != null)
        infoResult.movetoken = ValueParser.ParseString(xattribute18.Value);
      XAttribute xattribute19 = element.Attribute((XName) "blocktoken");
      if (xattribute19 != null)
        infoResult.blocktoken = ValueParser.ParseString(xattribute19.Value);
      XAttribute xattribute20 = element.Attribute((XName) "unblocktoken");
      if (xattribute20 != null)
        infoResult.unblocktoken = ValueParser.ParseString(xattribute20.Value);
      XAttribute xattribute21 = element.Attribute((XName) "emailtoken");
      if (xattribute21 != null)
        infoResult.emailtoken = ValueParser.ParseString(xattribute21.Value);
      XAttribute xattribute22 = element.Attribute((XName) "importtoken");
      if (xattribute22 != null)
        infoResult.importtoken = ValueParser.ParseString(xattribute22.Value);
      XAttribute xattribute23 = element.Attribute((XName) "watchtoken");
      if (xattribute23 != null)
        infoResult.watchtoken = ValueParser.ParseString(xattribute23.Value);
      XAttribute xattribute24 = element.Attribute((XName) "watched");
      if (xattribute24 != null)
        infoResult.watched = ValueParser.ParseBoolean(xattribute24.Value);
      XAttribute xattribute25 = element.Attribute((XName) "watchers");
      if (xattribute25 != null && xattribute25.Value != "")
        infoResult.watchers = new int?(ValueParser.ParseInt32(xattribute25.Value));
      XAttribute xattribute26 = element.Attribute((XName) "notificationtimestamp");
      if (xattribute26 != null && xattribute26.Value != "")
        infoResult.notificationtimestamp = new DateTime?(ValueParser.ParseDateTime(xattribute26.Value));
      XAttribute xattribute27 = element.Attribute((XName) "talkid");
      if (xattribute27 != null && xattribute27.Value != "")
        infoResult.talkid = new long?(ValueParser.ParseInt64(xattribute27.Value));
      XAttribute xattribute28 = element.Attribute((XName) "subjectid");
      if (xattribute28 != null && xattribute28.Value != "")
        infoResult.subjectid = new long?(ValueParser.ParseInt64(xattribute28.Value));
      XAttribute xattribute29 = element.Attribute((XName) "fullurl");
      if (xattribute29 != null)
        infoResult.fullurl = ValueParser.ParseString(xattribute29.Value);
      XAttribute xattribute30 = element.Attribute((XName) "editurl");
      if (xattribute30 != null)
        infoResult.editurl = ValueParser.ParseString(xattribute30.Value);
      XAttribute xattribute31 = element.Attribute((XName) "readable");
      if (xattribute31 != null)
        infoResult.readable = ValueParser.ParseBoolean(xattribute31.Value);
      XAttribute xattribute32 = element.Attribute((XName) "preload");
      if (xattribute32 != null)
        infoResult.preload = ValueParser.ParseString(xattribute32.Value);
      XAttribute xattribute33 = element.Attribute((XName) "displaytitle");
      if (xattribute33 != null)
        infoResult.displaytitle = ValueParser.ParseString(xattribute33.Value);
      return infoResult;
    }

    public override string ToString()
    {
      return string.Format("pageid: {0}; ns: {1}; title: {2}; missing: {3}; invalid: {4}; special: {5}; touched: {6}; lastrevid: {7}; counter: {8}; length: {9}; redirect: {10}; new: {11}; starttimestamp: {12}; contentmodel: {13}; edittoken: {14}; deletetoken: {15}; protecttoken: {16}; movetoken: {17}; blocktoken: {18}; unblocktoken: {19}; emailtoken: {20}; importtoken: {21}; watchtoken: {22}; watched: {23}; watchers: {24}; notificationtimestamp: {25}; talkid: {26}; subjectid: {27}; fullurl: {28}; editurl: {29}; readable: {30}; preload: {31}; displaytitle: {32}", (object) this.pageid, (object) this.ns, (object) this.title, (this.missing ? 1 : 0), (this.invalid ? 1 : 0), (this.special ? 1 : 0), (object) this.touched, (object) this.lastrevid, (object) this.counter, (object) this.length, (this.redirect ? 1 : 0), (this.@new ? 1 : 0), (object) this.starttimestamp, (object) this.contentmodel, (object) this.edittoken, (object) this.deletetoken, (object) this.protecttoken, (object) this.movetoken, (object) this.blocktoken, (object) this.unblocktoken, (object) this.emailtoken, (object) this.importtoken, (object) this.watchtoken, (this.watched ? 1 : 0), (object) this.watchers, (object) this.notificationtimestamp, (object) this.talkid, (object) this.subjectid, (object) this.fullurl, (object) this.editurl, (this.readable ? 1 : 0), (object) this.preload, (object) this.displaytitle);
    }
  }
}
