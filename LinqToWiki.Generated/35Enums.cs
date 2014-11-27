// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.categoriesshow
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;

namespace LinqToWiki.Generated
{
  public sealed class categoriesshow : StringValue
  {
    public static readonly categoriesshow hidden = new categoriesshow("hidden");
    public static readonly categoriesshow not_hidden = new categoriesshow("!hidden");

    internal categoriesshow(string value)
      : base(value)
    {
    }

    public static bool operator ==(categoriesshow first, categoriesshow second)
    {
      return object.Equals((object) first, (object) second);
    }

    public static bool operator !=(categoriesshow first, categoriesshow second)
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
