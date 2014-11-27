// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.recentchangeslogtype
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;

namespace LinqToWiki.Generated
{
  public sealed class recentchangeslogtype : StringValue
  {
    public static readonly recentchangeslogtype none = new recentchangeslogtype("");
    public static readonly recentchangeslogtype block = new recentchangeslogtype("block");
    public static readonly recentchangeslogtype protect = new recentchangeslogtype("protect");
    public static readonly recentchangeslogtype rights = new recentchangeslogtype("rights");
    public static readonly recentchangeslogtype delete = new recentchangeslogtype("delete");
    public static readonly recentchangeslogtype upload = new recentchangeslogtype("upload");
    public static readonly recentchangeslogtype move = new recentchangeslogtype("move");
    public static readonly recentchangeslogtype import = new recentchangeslogtype("import");
    public static readonly recentchangeslogtype patrol = new recentchangeslogtype("patrol");
    public static readonly recentchangeslogtype merge = new recentchangeslogtype("merge");
    public static readonly recentchangeslogtype suppress = new recentchangeslogtype("suppress");
    public static readonly recentchangeslogtype review = new recentchangeslogtype("review");
    public static readonly recentchangeslogtype stable = new recentchangeslogtype("stable");
    public static readonly recentchangeslogtype spamblacklist = new recentchangeslogtype("spamblacklist");
    public static readonly recentchangeslogtype gblblock = new recentchangeslogtype("gblblock");
    public static readonly recentchangeslogtype renameuser = new recentchangeslogtype("renameuser");
    public static readonly recentchangeslogtype globalauth = new recentchangeslogtype("globalauth");
    public static readonly recentchangeslogtype gblrights = new recentchangeslogtype("gblrights");
    public static readonly recentchangeslogtype abusefilter = new recentchangeslogtype("abusefilter");
    public static readonly recentchangeslogtype articlefeedbackv5 = new recentchangeslogtype("articlefeedbackv5");
    public static readonly recentchangeslogtype pagetriage_curation = new recentchangeslogtype("pagetriage-curation");
    public static readonly recentchangeslogtype pagetriage_deletion = new recentchangeslogtype("pagetriage-deletion");
    public static readonly recentchangeslogtype institution = new recentchangeslogtype("institution");
    public static readonly recentchangeslogtype course = new recentchangeslogtype("course");
    public static readonly recentchangeslogtype student = new recentchangeslogtype("student");
    public static readonly recentchangeslogtype online = new recentchangeslogtype("online");
    public static readonly recentchangeslogtype campus = new recentchangeslogtype("campus");
    public static readonly recentchangeslogtype instructor = new recentchangeslogtype("instructor");
    public static readonly recentchangeslogtype thanks = new recentchangeslogtype("thanks");
    public static readonly recentchangeslogtype newusers = new recentchangeslogtype("newusers");

    internal recentchangeslogtype(string value)
      : base(value)
    {
    }

    public static bool operator ==(recentchangeslogtype first, recentchangeslogtype second)
    {
      return object.Equals((object) first, (object) second);
    }

    public static bool operator !=(recentchangeslogtype first, recentchangeslogtype second)
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
