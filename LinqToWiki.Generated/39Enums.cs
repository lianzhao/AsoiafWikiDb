// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.exturlusageprotocol
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;

namespace LinqToWiki.Generated
{
  public sealed class exturlusageprotocol : StringValue
  {
    public static readonly exturlusageprotocol none = new exturlusageprotocol("");
    public static readonly exturlusageprotocol http = new exturlusageprotocol("http");
    public static readonly exturlusageprotocol https = new exturlusageprotocol("https");
    public static readonly exturlusageprotocol ftp = new exturlusageprotocol("ftp");
    public static readonly exturlusageprotocol ftps = new exturlusageprotocol("ftps");
    public static readonly exturlusageprotocol ssh = new exturlusageprotocol("ssh");
    public static readonly exturlusageprotocol sftp = new exturlusageprotocol("sftp");
    public static readonly exturlusageprotocol irc = new exturlusageprotocol("irc");
    public static readonly exturlusageprotocol ircs = new exturlusageprotocol("ircs");
    public static readonly exturlusageprotocol xmpp = new exturlusageprotocol("xmpp");
    public static readonly exturlusageprotocol sip = new exturlusageprotocol("sip");
    public static readonly exturlusageprotocol sips = new exturlusageprotocol("sips");
    public static readonly exturlusageprotocol gopher = new exturlusageprotocol("gopher");
    public static readonly exturlusageprotocol telnet = new exturlusageprotocol("telnet");
    public static readonly exturlusageprotocol nntp = new exturlusageprotocol("nntp");
    public static readonly exturlusageprotocol worldwind = new exturlusageprotocol("worldwind");
    public static readonly exturlusageprotocol mailto = new exturlusageprotocol("mailto");
    public static readonly exturlusageprotocol tel = new exturlusageprotocol("tel");
    public static readonly exturlusageprotocol sms = new exturlusageprotocol("sms");
    public static readonly exturlusageprotocol news = new exturlusageprotocol("news");
    public static readonly exturlusageprotocol svn = new exturlusageprotocol("svn");
    public static readonly exturlusageprotocol git = new exturlusageprotocol("git");
    public static readonly exturlusageprotocol mms = new exturlusageprotocol("mms");
    public static readonly exturlusageprotocol bitcoin = new exturlusageprotocol("bitcoin");
    public static readonly exturlusageprotocol magnet = new exturlusageprotocol("magnet");
    public static readonly exturlusageprotocol urn = new exturlusageprotocol("urn");
    public static readonly exturlusageprotocol geo = new exturlusageprotocol("geo");

    internal exturlusageprotocol(string value)
      : base(value)
    {
    }

    public static bool operator ==(exturlusageprotocol first, exturlusageprotocol second)
    {
      return object.Equals((object) first, (object) second);
    }

    public static bool operator !=(exturlusageprotocol first, exturlusageprotocol second)
    {
      return !object.Equals((object) first, (object) second);
    }

    public override bool Equals(object obj)
    {
      return base.Equals(obj);
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }
  }
}
