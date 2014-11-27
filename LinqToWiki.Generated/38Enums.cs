// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.extlinksprotocol
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;

namespace LinqToWiki.Generated
{
  public sealed class extlinksprotocol : StringValue
  {
    public static readonly extlinksprotocol none = new extlinksprotocol("");
    public static readonly extlinksprotocol http = new extlinksprotocol("http");
    public static readonly extlinksprotocol https = new extlinksprotocol("https");
    public static readonly extlinksprotocol ftp = new extlinksprotocol("ftp");
    public static readonly extlinksprotocol ftps = new extlinksprotocol("ftps");
    public static readonly extlinksprotocol ssh = new extlinksprotocol("ssh");
    public static readonly extlinksprotocol sftp = new extlinksprotocol("sftp");
    public static readonly extlinksprotocol irc = new extlinksprotocol("irc");
    public static readonly extlinksprotocol ircs = new extlinksprotocol("ircs");
    public static readonly extlinksprotocol xmpp = new extlinksprotocol("xmpp");
    public static readonly extlinksprotocol sip = new extlinksprotocol("sip");
    public static readonly extlinksprotocol sips = new extlinksprotocol("sips");
    public static readonly extlinksprotocol gopher = new extlinksprotocol("gopher");
    public static readonly extlinksprotocol telnet = new extlinksprotocol("telnet");
    public static readonly extlinksprotocol nntp = new extlinksprotocol("nntp");
    public static readonly extlinksprotocol worldwind = new extlinksprotocol("worldwind");
    public static readonly extlinksprotocol mailto = new extlinksprotocol("mailto");
    public static readonly extlinksprotocol tel = new extlinksprotocol("tel");
    public static readonly extlinksprotocol sms = new extlinksprotocol("sms");
    public static readonly extlinksprotocol news = new extlinksprotocol("news");
    public static readonly extlinksprotocol svn = new extlinksprotocol("svn");
    public static readonly extlinksprotocol git = new extlinksprotocol("git");
    public static readonly extlinksprotocol mms = new extlinksprotocol("mms");
    public static readonly extlinksprotocol bitcoin = new extlinksprotocol("bitcoin");
    public static readonly extlinksprotocol magnet = new extlinksprotocol("magnet");
    public static readonly extlinksprotocol urn = new extlinksprotocol("urn");
    public static readonly extlinksprotocol geo = new extlinksprotocol("geo");

    internal extlinksprotocol(string value)
      : base(value)
    {
    }

    public static bool operator ==(extlinksprotocol first, extlinksprotocol second)
    {
      return object.Equals((object) first, (object) second);
    }

    public static bool operator !=(extlinksprotocol first, extlinksprotocol second)
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
