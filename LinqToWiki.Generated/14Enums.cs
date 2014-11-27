// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.purgegenerator
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;

namespace LinqToWiki.Generated
{
  public sealed class purgegenerator : StringValue
  {
    public static readonly purgegenerator allcategories = new purgegenerator("allcategories");
    public static readonly purgegenerator allimages = new purgegenerator("allimages");
    public static readonly purgegenerator alllinks = new purgegenerator("alllinks");
    public static readonly purgegenerator allpages = new purgegenerator("allpages");
    public static readonly purgegenerator alltransclusions = new purgegenerator("alltransclusions");
    public static readonly purgegenerator backlinks = new purgegenerator("backlinks");
    public static readonly purgegenerator categories = new purgegenerator("categories");
    public static readonly purgegenerator categorymembers = new purgegenerator("categorymembers");
    public static readonly purgegenerator duplicatefiles = new purgegenerator("duplicatefiles");
    public static readonly purgegenerator embeddedin = new purgegenerator("embeddedin");
    public static readonly purgegenerator exturlusage = new purgegenerator("exturlusage");
    public static readonly purgegenerator geosearch = new purgegenerator("geosearch");
    public static readonly purgegenerator images = new purgegenerator("images");
    public static readonly purgegenerator imageusage = new purgegenerator("imageusage");
    public static readonly purgegenerator iwbacklinks = new purgegenerator("iwbacklinks");
    public static readonly purgegenerator langbacklinks = new purgegenerator("langbacklinks");
    public static readonly purgegenerator links = new purgegenerator("links");
    public static readonly purgegenerator oldreviewedpages = new purgegenerator("oldreviewedpages");
    public static readonly purgegenerator pageswithprop = new purgegenerator("pageswithprop");
    public static readonly purgegenerator protectedtitles = new purgegenerator("protectedtitles");
    public static readonly purgegenerator querypage = new purgegenerator("querypage");
    public static readonly purgegenerator random = new purgegenerator("random");
    public static readonly purgegenerator recentchanges = new purgegenerator("recentchanges");
    public static readonly purgegenerator search = new purgegenerator("search");
    public static readonly purgegenerator templates = new purgegenerator("templates");
    public static readonly purgegenerator watchlist = new purgegenerator("watchlist");
    public static readonly purgegenerator watchlistraw = new purgegenerator("watchlistraw");

    internal purgegenerator(string value)
      : base(value)
    {
    }

    public static bool operator ==(purgegenerator first, purgegenerator second)
    {
      return object.Equals((object) first, (object) second);
    }

    public static bool operator !=(purgegenerator first, purgegenerator second)
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
