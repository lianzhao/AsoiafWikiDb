// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.usercontribsshow
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;

namespace LinqToWiki.Generated
{
  public sealed class usercontribsshow : StringValue
  {
    public static readonly usercontribsshow minor = new usercontribsshow("minor");
    public static readonly usercontribsshow not_minor = new usercontribsshow("!minor");
    public static readonly usercontribsshow patrolled = new usercontribsshow("patrolled");
    public static readonly usercontribsshow not_patrolled = new usercontribsshow("!patrolled");

    internal usercontribsshow(string value)
      : base(value)
    {
    }

    public static bool operator ==(usercontribsshow first, usercontribsshow second)
    {
      return object.Equals((object) first, (object) second);
    }

    public static bool operator !=(usercontribsshow first, usercontribsshow second)
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
