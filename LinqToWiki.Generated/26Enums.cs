// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.allpagesprtype
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;

namespace LinqToWiki.Generated
{
  public sealed class allpagesprtype : StringValue
  {
    public static readonly allpagesprtype edit = new allpagesprtype("edit");
    public static readonly allpagesprtype move = new allpagesprtype("move");
    public static readonly allpagesprtype upload = new allpagesprtype("upload");

    internal allpagesprtype(string value)
      : base(value)
    {
    }

    public static bool operator ==(allpagesprtype first, allpagesprtype second)
    {
      return object.Equals((object) first, (object) second);
    }

    public static bool operator !=(allpagesprtype first, allpagesprtype second)
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
