// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.editresult
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;

namespace LinqToWiki.Generated
{
  public sealed class editresult : StringValue
  {
    public static readonly editresult Success = new editresult("Success");
    public static readonly editresult Failure = new editresult("Failure");

    internal editresult(string value)
      : base(value)
    {
    }

    public static bool operator ==(editresult first, editresult second)
    {
      return object.Equals((object) first, (object) second);
    }

    public static bool operator !=(editresult first, editresult second)
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
