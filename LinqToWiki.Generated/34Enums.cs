// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.blocksshow
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;

namespace LinqToWiki.Generated
{
  public sealed class blocksshow : StringValue
  {
    public static readonly blocksshow account = new blocksshow("account");
    public static readonly blocksshow not_account = new blocksshow("!account");
    public static readonly blocksshow temp = new blocksshow("temp");
    public static readonly blocksshow not_temp = new blocksshow("!temp");
    public static readonly blocksshow ip = new blocksshow("ip");
    public static readonly blocksshow not_ip = new blocksshow("!ip");
    public static readonly blocksshow range = new blocksshow("range");
    public static readonly blocksshow not_range = new blocksshow("!range");

    internal blocksshow(string value)
      : base(value)
    {
    }

    public static bool operator ==(blocksshow first, blocksshow second)
    {
      return object.Equals((object) first, (object) second);
    }

    public static bool operator !=(blocksshow first, blocksshow second)
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
