// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.categorymemberstype
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;

namespace LinqToWiki.Generated
{
  public sealed class categorymemberstype : StringValue
  {
    public static readonly categorymemberstype page = new categorymemberstype("page");
    public static readonly categorymemberstype subcat = new categorymemberstype("subcat");
    public static readonly categorymemberstype file = new categorymemberstype("file");

    internal categorymemberstype(string value)
      : base(value)
    {
    }

    public static bool operator ==(categorymemberstype first, categorymemberstype second)
    {
      return object.Equals((object) first, (object) second);
    }

    public static bool operator !=(categorymemberstype first, categorymemberstype second)
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
