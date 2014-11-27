// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.recentchangestype
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;

namespace LinqToWiki.Generated
{
  public sealed class recentchangestype : StringValue
  {
    public static readonly recentchangestype edit = new recentchangestype("edit");
    public static readonly recentchangestype @new = new recentchangestype("new");
    public static readonly recentchangestype move = new recentchangestype("move");
    public static readonly recentchangestype log = new recentchangestype("log");
    public static readonly recentchangestype move_over_redirect = new recentchangestype("move over redirect");

    internal recentchangestype(string value)
      : base(value)
    {
    }

    public static bool operator ==(recentchangestype first, recentchangestype second)
    {
      return object.Equals((object) first, (object) second);
    }

    public static bool operator !=(recentchangestype first, recentchangestype second)
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
