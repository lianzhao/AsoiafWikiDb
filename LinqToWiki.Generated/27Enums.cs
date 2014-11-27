// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.allpagesprlevel
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;

namespace LinqToWiki.Generated
{
  public sealed class allpagesprlevel : StringValue
  {
    public static readonly allpagesprlevel none = new allpagesprlevel("");
    public static readonly allpagesprlevel autoconfirmed = new allpagesprlevel("autoconfirmed");
    public static readonly allpagesprlevel sysop = new allpagesprlevel("sysop");

    internal allpagesprlevel(string value)
      : base(value)
    {
    }

    public static bool operator ==(allpagesprlevel first, allpagesprlevel second)
    {
      return object.Equals((object) first, (object) second);
    }

    public static bool operator !=(allpagesprlevel first, allpagesprlevel second)
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
