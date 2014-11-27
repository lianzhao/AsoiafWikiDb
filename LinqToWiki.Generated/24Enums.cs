// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.allmessagescustomised
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;

namespace LinqToWiki.Generated
{
  public sealed class allmessagescustomised : StringValue
  {
    public static readonly allmessagescustomised all = new allmessagescustomised("all");
    public static readonly allmessagescustomised modified = new allmessagescustomised("modified");
    public static readonly allmessagescustomised unmodified = new allmessagescustomised("unmodified");

    internal allmessagescustomised(string value)
      : base(value)
    {
    }

    public static bool operator ==(allmessagescustomised first, allmessagescustomised second)
    {
      return object.Equals((object) first, (object) second);
    }

    public static bool operator !=(allmessagescustomised first, allmessagescustomised second)
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
