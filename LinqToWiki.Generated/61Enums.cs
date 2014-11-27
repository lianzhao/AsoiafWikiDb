// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.watchlistrawshow
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;

namespace LinqToWiki.Generated
{
  public sealed class watchlistrawshow : StringValue
  {
    public static readonly watchlistrawshow changed = new watchlistrawshow("changed");
    public static readonly watchlistrawshow not_changed = new watchlistrawshow("!changed");

    internal watchlistrawshow(string value)
      : base(value)
    {
    }

    public static bool operator ==(watchlistrawshow first, watchlistrawshow second)
    {
      return object.Equals((object) first, (object) second);
    }

    public static bool operator !=(watchlistrawshow first, watchlistrawshow second)
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
