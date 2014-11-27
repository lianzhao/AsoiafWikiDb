// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.recentchangestype2
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;

namespace LinqToWiki.Generated
{
  public sealed class recentchangestype2 : StringValue
  {
    public static readonly recentchangestype2 edit = new recentchangestype2("edit");
    public static readonly recentchangestype2 external = new recentchangestype2("external");
    public static readonly recentchangestype2 @new = new recentchangestype2("new");
    public static readonly recentchangestype2 log = new recentchangestype2("log");

    internal recentchangestype2(string value)
      : base(value)
    {
    }

    public static bool operator ==(recentchangestype2 first, recentchangestype2 second)
    {
      return object.Equals((object) first, (object) second);
    }

    public static bool operator !=(recentchangestype2 first, recentchangestype2 second)
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
