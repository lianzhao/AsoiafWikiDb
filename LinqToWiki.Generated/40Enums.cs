// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.imageusagefilterredir
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;

namespace LinqToWiki.Generated
{
  public sealed class imageusagefilterredir : StringValue
  {
    public static readonly imageusagefilterredir all = new imageusagefilterredir("all");
    public static readonly imageusagefilterredir redirects = new imageusagefilterredir("redirects");
    public static readonly imageusagefilterredir nonredirects = new imageusagefilterredir("nonredirects");

    internal imageusagefilterredir(string value)
      : base(value)
    {
    }

    public static bool operator ==(imageusagefilterredir first, imageusagefilterredir second)
    {
      return object.Equals((object) first, (object) second);
    }

    public static bool operator !=(imageusagefilterredir first, imageusagefilterredir second)
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
