// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.watchlisttype
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;

namespace LinqToWiki.Generated
{
  public sealed class watchlisttype : StringValue
  {
    public static readonly watchlisttype edit = new watchlisttype("edit");
    public static readonly watchlisttype @new = new watchlisttype("new");
    public static readonly watchlisttype move = new watchlisttype("move");
    public static readonly watchlisttype log = new watchlisttype("log");
    public static readonly watchlisttype move_over_redirect = new watchlisttype("move over redirect");

    internal watchlisttype(string value)
      : base(value)
    {
    }

    public static bool operator ==(watchlisttype first, watchlisttype second)
    {
      return object.Equals((object) first, (object) second);
    }

    public static bool operator !=(watchlisttype first, watchlisttype second)
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
