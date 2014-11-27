// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.protectedtitleslevel
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;

namespace LinqToWiki.Generated
{
  public sealed class protectedtitleslevel : StringValue
  {
    public static readonly protectedtitleslevel autoconfirmed = new protectedtitleslevel("autoconfirmed");
    public static readonly protectedtitleslevel sysop = new protectedtitleslevel("sysop");

    internal protectedtitleslevel(string value)
      : base(value)
    {
    }

    public static bool operator ==(protectedtitleslevel first, protectedtitleslevel second)
    {
      return object.Equals((object) first, (object) second);
    }

    public static bool operator !=(protectedtitleslevel first, protectedtitleslevel second)
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
