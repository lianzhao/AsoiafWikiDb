// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.watchlistshow
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;

namespace LinqToWiki.Generated
{
  public sealed class watchlistshow : StringValue
  {
    public static readonly watchlistshow minor = new watchlistshow("minor");
    public static readonly watchlistshow not_minor = new watchlistshow("!minor");
    public static readonly watchlistshow bot = new watchlistshow("bot");
    public static readonly watchlistshow not_bot = new watchlistshow("!bot");
    public static readonly watchlistshow anon = new watchlistshow("anon");
    public static readonly watchlistshow not_anon = new watchlistshow("!anon");
    public static readonly watchlistshow patrolled = new watchlistshow("patrolled");
    public static readonly watchlistshow not_patrolled = new watchlistshow("!patrolled");

    internal watchlistshow(string value)
      : base(value)
    {
    }

    public static bool operator ==(watchlistshow first, watchlistshow second)
    {
      return object.Equals((object) first, (object) second);
    }

    public static bool operator !=(watchlistshow first, watchlistshow second)
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
