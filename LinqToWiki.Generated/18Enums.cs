// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.setnotificationtimestampgenerator
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;

namespace LinqToWiki.Generated
{
  public sealed class setnotificationtimestampgenerator : StringValue
  {
    public static readonly setnotificationtimestampgenerator allcategories = new setnotificationtimestampgenerator("allcategories");
    public static readonly setnotificationtimestampgenerator allimages = new setnotificationtimestampgenerator("allimages");
    public static readonly setnotificationtimestampgenerator alllinks = new setnotificationtimestampgenerator("alllinks");
    public static readonly setnotificationtimestampgenerator allpages = new setnotificationtimestampgenerator("allpages");
    public static readonly setnotificationtimestampgenerator alltransclusions = new setnotificationtimestampgenerator("alltransclusions");
    public static readonly setnotificationtimestampgenerator backlinks = new setnotificationtimestampgenerator("backlinks");
    public static readonly setnotificationtimestampgenerator categories = new setnotificationtimestampgenerator("categories");
    public static readonly setnotificationtimestampgenerator categorymembers = new setnotificationtimestampgenerator("categorymembers");
    public static readonly setnotificationtimestampgenerator duplicatefiles = new setnotificationtimestampgenerator("duplicatefiles");
    public static readonly setnotificationtimestampgenerator embeddedin = new setnotificationtimestampgenerator("embeddedin");
    public static readonly setnotificationtimestampgenerator exturlusage = new setnotificationtimestampgenerator("exturlusage");
    public static readonly setnotificationtimestampgenerator geosearch = new setnotificationtimestampgenerator("geosearch");
    public static readonly setnotificationtimestampgenerator images = new setnotificationtimestampgenerator("images");
    public static readonly setnotificationtimestampgenerator imageusage = new setnotificationtimestampgenerator("imageusage");
    public static readonly setnotificationtimestampgenerator iwbacklinks = new setnotificationtimestampgenerator("iwbacklinks");
    public static readonly setnotificationtimestampgenerator langbacklinks = new setnotificationtimestampgenerator("langbacklinks");
    public static readonly setnotificationtimestampgenerator links = new setnotificationtimestampgenerator("links");
    public static readonly setnotificationtimestampgenerator oldreviewedpages = new setnotificationtimestampgenerator("oldreviewedpages");
    public static readonly setnotificationtimestampgenerator pageswithprop = new setnotificationtimestampgenerator("pageswithprop");
    public static readonly setnotificationtimestampgenerator protectedtitles = new setnotificationtimestampgenerator("protectedtitles");
    public static readonly setnotificationtimestampgenerator querypage = new setnotificationtimestampgenerator("querypage");
    public static readonly setnotificationtimestampgenerator random = new setnotificationtimestampgenerator("random");
    public static readonly setnotificationtimestampgenerator recentchanges = new setnotificationtimestampgenerator("recentchanges");
    public static readonly setnotificationtimestampgenerator search = new setnotificationtimestampgenerator("search");
    public static readonly setnotificationtimestampgenerator templates = new setnotificationtimestampgenerator("templates");
    public static readonly setnotificationtimestampgenerator watchlist = new setnotificationtimestampgenerator("watchlist");
    public static readonly setnotificationtimestampgenerator watchlistraw = new setnotificationtimestampgenerator("watchlistraw");

    internal setnotificationtimestampgenerator(string value)
      : base(value)
    {
    }

    public static bool operator ==(setnotificationtimestampgenerator first, setnotificationtimestampgenerator second)
    {
      return object.Equals((object) first, (object) second);
    }

    public static bool operator !=(setnotificationtimestampgenerator first, setnotificationtimestampgenerator second)
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
