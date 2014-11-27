// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.optionsresetkinds
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;

namespace LinqToWiki.Generated
{
  public sealed class optionsresetkinds : StringValue
  {
    public static readonly optionsresetkinds registered = new optionsresetkinds("registered");
    public static readonly optionsresetkinds registered_multiselect = new optionsresetkinds("registered-multiselect");
    public static readonly optionsresetkinds registered_checkmatrix = new optionsresetkinds("registered-checkmatrix");
    public static readonly optionsresetkinds userjs = new optionsresetkinds("userjs");
    public static readonly optionsresetkinds unused = new optionsresetkinds("unused");
    public static readonly optionsresetkinds all = new optionsresetkinds("all");

    internal optionsresetkinds(string value)
      : base(value)
    {
    }

    public static bool operator ==(optionsresetkinds first, optionsresetkinds second)
    {
      return object.Equals((object) first, (object) second);
    }

    public static bool operator !=(optionsresetkinds first, optionsresetkinds second)
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
