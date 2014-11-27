// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.tokenstype
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;

namespace LinqToWiki.Generated
{
  public sealed class tokenstype : StringValue
  {
    public static readonly tokenstype block = new tokenstype("block");
    public static readonly tokenstype centralauth = new tokenstype("centralauth");
    public static readonly tokenstype delete = new tokenstype("delete");
    public static readonly tokenstype deleteglobalaccount = new tokenstype("deleteglobalaccount");
    public static readonly tokenstype edit = new tokenstype("edit");
    public static readonly tokenstype email = new tokenstype("email");
    public static readonly tokenstype import = new tokenstype("import");
    public static readonly tokenstype move = new tokenstype("move");
    public static readonly tokenstype options = new tokenstype("options");
    public static readonly tokenstype patrol = new tokenstype("patrol");
    public static readonly tokenstype protect = new tokenstype("protect");
    public static readonly tokenstype setglobalaccountstatus = new tokenstype("setglobalaccountstatus");
    public static readonly tokenstype unblock = new tokenstype("unblock");
    public static readonly tokenstype watch = new tokenstype("watch");

    internal tokenstype(string value)
      : base(value)
    {
    }

    public static bool operator ==(tokenstype first, tokenstype second)
    {
      return object.Equals((object) first, (object) second);
    }

    public static bool operator !=(tokenstype first, tokenstype second)
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
