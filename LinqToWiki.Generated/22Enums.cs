// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.uploadwatchlist
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;

namespace LinqToWiki.Generated
{
  public sealed class uploadwatchlist : StringValue
  {
    public static readonly uploadwatchlist watch = new uploadwatchlist("watch");
    public static readonly uploadwatchlist preferences = new uploadwatchlist("preferences");
    public static readonly uploadwatchlist nochange = new uploadwatchlist("nochange");

    internal uploadwatchlist(string value)
      : base(value)
    {
    }

    public static bool operator ==(uploadwatchlist first, uploadwatchlist second)
    {
      return object.Equals((object) first, (object) second);
    }

    public static bool operator !=(uploadwatchlist first, uploadwatchlist second)
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
