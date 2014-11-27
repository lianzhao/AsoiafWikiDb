// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.Entities.tokensResult
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;
using System.Xml.Linq;

namespace LinqToWiki.Generated.Entities
{
  public sealed class tokensResult
  {
    public string blocktoken { get; private set; }

    public string centralauthtoken { get; private set; }

    public string deletetoken { get; private set; }

    public string deleteglobalaccounttoken { get; private set; }

    public string edittoken { get; private set; }

    public string emailtoken { get; private set; }

    public string importtoken { get; private set; }

    public string movetoken { get; private set; }

    public string optionstoken { get; private set; }

    public string patroltoken { get; private set; }

    public string protecttoken { get; private set; }

    public string setglobalaccountstatustoken { get; private set; }

    public string unblocktoken { get; private set; }

    public string watchtoken { get; private set; }

    private tokensResult()
    {
    }

    public static tokensResult Parse(XElement element, WikiInfo wiki)
    {
      tokensResult tokensResult = new tokensResult();
      XAttribute xattribute1 = element.Attribute((XName) "blocktoken");
      if (xattribute1 != null)
        tokensResult.blocktoken = ValueParser.ParseString(xattribute1.Value);
      XAttribute xattribute2 = element.Attribute((XName) "centralauthtoken");
      if (xattribute2 != null)
        tokensResult.centralauthtoken = ValueParser.ParseString(xattribute2.Value);
      XAttribute xattribute3 = element.Attribute((XName) "deletetoken");
      if (xattribute3 != null)
        tokensResult.deletetoken = ValueParser.ParseString(xattribute3.Value);
      XAttribute xattribute4 = element.Attribute((XName) "deleteglobalaccounttoken");
      if (xattribute4 != null)
        tokensResult.deleteglobalaccounttoken = ValueParser.ParseString(xattribute4.Value);
      XAttribute xattribute5 = element.Attribute((XName) "edittoken");
      if (xattribute5 != null)
        tokensResult.edittoken = ValueParser.ParseString(xattribute5.Value);
      XAttribute xattribute6 = element.Attribute((XName) "emailtoken");
      if (xattribute6 != null)
        tokensResult.emailtoken = ValueParser.ParseString(xattribute6.Value);
      XAttribute xattribute7 = element.Attribute((XName) "importtoken");
      if (xattribute7 != null)
        tokensResult.importtoken = ValueParser.ParseString(xattribute7.Value);
      XAttribute xattribute8 = element.Attribute((XName) "movetoken");
      if (xattribute8 != null)
        tokensResult.movetoken = ValueParser.ParseString(xattribute8.Value);
      XAttribute xattribute9 = element.Attribute((XName) "optionstoken");
      if (xattribute9 != null)
        tokensResult.optionstoken = ValueParser.ParseString(xattribute9.Value);
      XAttribute xattribute10 = element.Attribute((XName) "patroltoken");
      if (xattribute10 != null)
        tokensResult.patroltoken = ValueParser.ParseString(xattribute10.Value);
      XAttribute xattribute11 = element.Attribute((XName) "protecttoken");
      if (xattribute11 != null)
        tokensResult.protecttoken = ValueParser.ParseString(xattribute11.Value);
      XAttribute xattribute12 = element.Attribute((XName) "setglobalaccountstatustoken");
      if (xattribute12 != null)
        tokensResult.setglobalaccountstatustoken = ValueParser.ParseString(xattribute12.Value);
      XAttribute xattribute13 = element.Attribute((XName) "unblocktoken");
      if (xattribute13 != null)
        tokensResult.unblocktoken = ValueParser.ParseString(xattribute13.Value);
      XAttribute xattribute14 = element.Attribute((XName) "watchtoken");
      if (xattribute14 != null)
        tokensResult.watchtoken = ValueParser.ParseString(xattribute14.Value);
      return tokensResult;
    }

    public override string ToString()
    {
      return string.Format("blocktoken: {0}; centralauthtoken: {1}; deletetoken: {2}; deleteglobalaccounttoken: {3}; edittoken: {4}; emailtoken: {5}; importtoken: {6}; movetoken: {7}; optionstoken: {8}; patroltoken: {9}; protecttoken: {10}; setglobalaccountstatustoken: {11}; unblocktoken: {12}; watchtoken: {13}", (object) this.blocktoken, (object) this.centralauthtoken, (object) this.deletetoken, (object) this.deleteglobalaccounttoken, (object) this.edittoken, (object) this.emailtoken, (object) this.importtoken, (object) this.movetoken, (object) this.optionstoken, (object) this.patroltoken, (object) this.protecttoken, (object) this.setglobalaccountstatustoken, (object) this.unblocktoken, (object) this.watchtoken);
    }
  }
}
