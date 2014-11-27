// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.loginresult
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;

namespace LinqToWiki.Generated
{
  public sealed class loginresult : StringValue
  {
    public static readonly loginresult Success = new loginresult("Success");
    public static readonly loginresult NeedToken = new loginresult("NeedToken");
    public static readonly loginresult WrongToken = new loginresult("WrongToken");
    public static readonly loginresult NoName = new loginresult("NoName");
    public static readonly loginresult Illegal = new loginresult("Illegal");
    public static readonly loginresult WrongPluginPass = new loginresult("WrongPluginPass");
    public static readonly loginresult NotExists = new loginresult("NotExists");
    public static readonly loginresult WrongPass = new loginresult("WrongPass");
    public static readonly loginresult EmptyPass = new loginresult("EmptyPass");
    public static readonly loginresult CreateBlocked = new loginresult("CreateBlocked");
    public static readonly loginresult Throttled = new loginresult("Throttled");
    public static readonly loginresult Blocked = new loginresult("Blocked");
    public static readonly loginresult Aborted = new loginresult("Aborted");

    internal loginresult(string value)
      : base(value)
    {
    }

    public static bool operator ==(loginresult first, loginresult second)
    {
      return object.Equals((object) first, (object) second);
    }

    public static bool operator !=(loginresult first, loginresult second)
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
