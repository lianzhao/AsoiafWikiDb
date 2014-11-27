// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.importinterwikisource
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;

namespace LinqToWiki.Generated
{
  public sealed class importinterwikisource : StringValue
  {
    public static readonly importinterwikisource meta = new importinterwikisource("meta");
    public static readonly importinterwikisource nost = new importinterwikisource("nost");
    public static readonly importinterwikisource de = new importinterwikisource("de");
    public static readonly importinterwikisource es = new importinterwikisource("es");
    public static readonly importinterwikisource fr = new importinterwikisource("fr");
    public static readonly importinterwikisource it = new importinterwikisource("it");
    public static readonly importinterwikisource pl = new importinterwikisource("pl");
    public static readonly importinterwikisource outreachwiki = new importinterwikisource("outreachwiki");
    public static readonly importinterwikisource test2wiki = new importinterwikisource("test2wiki");

    internal importinterwikisource(string value)
      : base(value)
    {
    }

    public static bool operator ==(importinterwikisource first, importinterwikisource second)
    {
      return object.Equals((object) first, (object) second);
    }

    public static bool operator !=(importinterwikisource first, importinterwikisource second)
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
