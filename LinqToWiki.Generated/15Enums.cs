﻿// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.rollbackwatchlist
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;

namespace LinqToWiki.Generated
{
  public sealed class rollbackwatchlist : StringValue
  {
    public static readonly rollbackwatchlist watch = new rollbackwatchlist("watch");
    public static readonly rollbackwatchlist unwatch = new rollbackwatchlist("unwatch");
    public static readonly rollbackwatchlist preferences = new rollbackwatchlist("preferences");
    public static readonly rollbackwatchlist nochange = new rollbackwatchlist("nochange");

    internal rollbackwatchlist(string value)
      : base(value)
    {
    }

    public static bool operator ==(rollbackwatchlist first, rollbackwatchlist second)
    {
      return object.Equals((object) first, (object) second);
    }

    public static bool operator !=(rollbackwatchlist first, rollbackwatchlist second)
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
