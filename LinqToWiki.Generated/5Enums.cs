// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.editassert
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;

namespace LinqToWiki.Generated
{
  public sealed class editassert : StringValue
  {
    public static readonly editassert @true = new editassert("true");
    public static readonly editassert @false = new editassert("false");
    public static readonly editassert user = new editassert("user");
    public static readonly editassert bot = new editassert("bot");
    public static readonly editassert exists = new editassert("exists");
    public static readonly editassert test = new editassert("test");

    internal editassert(string value)
      : base(value)
    {
    }

    public static bool operator ==(editassert first, editassert second)
    {
      return object.Equals((object) first, (object) second);
    }

    public static bool operator !=(editassert first, editassert second)
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
