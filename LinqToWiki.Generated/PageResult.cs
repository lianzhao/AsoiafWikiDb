// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.PageResult
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Generated.Entities;
using System.Collections.Generic;

namespace LinqToWiki.Generated
{
  public static class PageResult
  {
    public static PageResult<TData> Create<TData>(infoResult info, IEnumerable<TData> data)
    {
      return new PageResult<TData>(info, data);
    }
  }
}
