﻿// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.editwatchlist
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;

namespace LinqToWiki.Generated
{
  public sealed class editwatchlist : StringValue
  {
    public static readonly editwatchlist watch = new editwatchlist("watch");
    public static readonly editwatchlist unwatch = new editwatchlist("unwatch");
    public static readonly editwatchlist preferences = new editwatchlist("preferences");
    public static readonly editwatchlist nochange = new editwatchlist("nochange");

    internal editwatchlist(string value)
      : base(value)
    {
    }

    public static bool operator ==(editwatchlist first, editwatchlist second)
    {
      return object.Equals((object) first, (object) second);
    }

    public static bool operator !=(editwatchlist first, editwatchlist second)
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
