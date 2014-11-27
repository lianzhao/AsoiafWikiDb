// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.recentchangesshow
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;

namespace LinqToWiki.Generated
{
  public sealed class recentchangesshow : StringValue
  {
    public static readonly recentchangesshow minor = new recentchangesshow("minor");
    public static readonly recentchangesshow not_minor = new recentchangesshow("!minor");
    public static readonly recentchangesshow bot = new recentchangesshow("bot");
    public static readonly recentchangesshow not_bot = new recentchangesshow("!bot");
    public static readonly recentchangesshow anon = new recentchangesshow("anon");
    public static readonly recentchangesshow not_anon = new recentchangesshow("!anon");
    public static readonly recentchangesshow redirect = new recentchangesshow("redirect");
    public static readonly recentchangesshow not_redirect = new recentchangesshow("!redirect");
    public static readonly recentchangesshow patrolled = new recentchangesshow("patrolled");
    public static readonly recentchangesshow not_patrolled = new recentchangesshow("!patrolled");

    internal recentchangesshow(string value)
      : base(value)
    {
    }

    public static bool operator ==(recentchangesshow first, recentchangesshow second)
    {
      return object.Equals((object) first, (object) second);
    }

    public static bool operator !=(recentchangesshow first, recentchangesshow second)
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
