// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.uploadresult
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;

namespace LinqToWiki.Generated
{
  public sealed class uploadresult : StringValue
  {
    public static readonly uploadresult Success = new uploadresult("Success");
    public static readonly uploadresult Warning = new uploadresult("Warning");
    public static readonly uploadresult Continue = new uploadresult("Continue");
    public static readonly uploadresult Queued = new uploadresult("Queued");

    internal uploadresult(string value)
      : base(value)
    {
    }

    public static bool operator ==(uploadresult first, uploadresult second)
    {
      return object.Equals((object) first, (object) second);
    }

    public static bool operator !=(uploadresult first, uploadresult second)
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
