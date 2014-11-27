// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.PageResult`1
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Generated.Entities;
using System.Collections.Generic;

namespace LinqToWiki.Generated
{
  public sealed class PageResult<TData>
  {
    public infoResult Info { get; private set; }

    public IEnumerable<TData> Data { get; private set; }

    public PageResult(infoResult info, IEnumerable<TData> data)
    {
      this.Info = info;
      this.Data = data;
    }
  }
}
