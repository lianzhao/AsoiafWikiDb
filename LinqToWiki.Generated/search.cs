// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.searchSelect
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki;
using LinqToWiki.Internals;
using System;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class searchSelect
  {
    public Namespace ns { get; private set; }

    public string title { get; private set; }

    public string snippet { get; private set; }

    public int size { get; private set; }

    public int wordcount { get; private set; }

    public DateTime timestamp { get; private set; }

    public string score { get; private set; }

    public string titlesnippet { get; private set; }

    public string redirecttitle { get; private set; }

    public string redirectsnippet { get; private set; }

    public string sectiontitle { get; private set; }

    public string sectionsnippet { get; private set; }

    public bool hasrelated { get; private set; }

    private searchSelect()
    {
    }

    public static searchSelect Parse(XElement element, WikiInfo wiki)
    {
      searchSelect searchSelect = new searchSelect();
      XAttribute xattribute1 = element.Attribute((XName) "ns");
      if (xattribute1 != null && xattribute1.Value != "")
        searchSelect.ns = ValueParser.ParseNamespace(xattribute1.Value, wiki);
      XAttribute xattribute2 = element.Attribute((XName) "title");
      if (xattribute2 != null)
        searchSelect.title = ValueParser.ParseString(xattribute2.Value);
      XAttribute xattribute3 = element.Attribute((XName) "snippet");
      if (xattribute3 != null)
        searchSelect.snippet = ValueParser.ParseString(xattribute3.Value);
      XAttribute xattribute4 = element.Attribute((XName) "size");
      if (xattribute4 != null && xattribute4.Value != "")
        searchSelect.size = ValueParser.ParseInt32(xattribute4.Value);
      XAttribute xattribute5 = element.Attribute((XName) "wordcount");
      if (xattribute5 != null && xattribute5.Value != "")
        searchSelect.wordcount = ValueParser.ParseInt32(xattribute5.Value);
      XAttribute xattribute6 = element.Attribute((XName) "timestamp");
      if (xattribute6 != null && xattribute6.Value != "")
        searchSelect.timestamp = ValueParser.ParseDateTime(xattribute6.Value);
      XAttribute xattribute7 = element.Attribute((XName) "score");
      if (xattribute7 != null)
        searchSelect.score = ValueParser.ParseString(xattribute7.Value);
      XAttribute xattribute8 = element.Attribute((XName) "titlesnippet");
      if (xattribute8 != null)
        searchSelect.titlesnippet = ValueParser.ParseString(xattribute8.Value);
      XAttribute xattribute9 = element.Attribute((XName) "redirecttitle");
      if (xattribute9 != null)
        searchSelect.redirecttitle = ValueParser.ParseString(xattribute9.Value);
      XAttribute xattribute10 = element.Attribute((XName) "redirectsnippet");
      if (xattribute10 != null)
        searchSelect.redirectsnippet = ValueParser.ParseString(xattribute10.Value);
      XAttribute xattribute11 = element.Attribute((XName) "sectiontitle");
      if (xattribute11 != null)
        searchSelect.sectiontitle = ValueParser.ParseString(xattribute11.Value);
      XAttribute xattribute12 = element.Attribute((XName) "sectionsnippet");
      if (xattribute12 != null)
        searchSelect.sectionsnippet = ValueParser.ParseString(xattribute12.Value);
      XAttribute xattribute13 = element.Attribute((XName) "hasrelated");
      if (xattribute13 != null)
        searchSelect.hasrelated = ValueParser.ParseBoolean(xattribute13.Value);
      return searchSelect;
    }

    public override string ToString()
    {
      return string.Format("ns: {0}; title: {1}; snippet: {2}; size: {3}; wordcount: {4}; timestamp: {5}; score: {6}; titlesnippet: {7}; redirecttitle: {8}; redirectsnippet: {9}; sectiontitle: {10}; sectionsnippet: {11}; hasrelated: {12}", (object) this.ns, (object) this.title, (object) this.snippet, (object) this.size, (object) this.wordcount, (object) this.timestamp, (object) this.score, (object) this.titlesnippet, (object) this.redirecttitle, (object) this.redirectsnippet, (object) this.sectiontitle, (object) this.sectionsnippet, (this.hasrelated ? 1 : 0));
    }
  }
}
