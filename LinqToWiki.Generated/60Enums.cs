// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.watchlisttype2
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;

namespace LinqToWiki.Generated
{
  public sealed class watchlisttype2 : StringValue
  {
    public static readonly watchlisttype2 edit = new watchlisttype2("edit");
    public static readonly watchlisttype2 external = new watchlisttype2("external");
    public static readonly watchlisttype2 @new = new watchlisttype2("new");
    public static readonly watchlisttype2 log = new watchlisttype2("log");

    internal watchlisttype2(string value)
      : base(value)
    {
    }

    public static bool operator ==(watchlisttype2 first, watchlisttype2 second)
    {
      return object.Equals((object) first, (object) second);
    }

    public static bool operator !=(watchlisttype2 first, watchlisttype2 second)
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
