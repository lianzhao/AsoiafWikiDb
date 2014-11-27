// Decompiled with JetBrains decompiler
// Type: LinqToWiki.Generated.watchlistlogtype
// Assembly: LinqToWiki.Generated, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A4304DCD-2C3F-4D9F-B552-69913FDA3067
// Assembly location: D:\work\my\AsoiafWikiDb\AsoiafWikiDb\bin\LinqToWiki.Generated.dll

using LinqToWiki.Internals;

namespace LinqToWiki.Generated
{
  public sealed class watchlistlogtype : StringValue
  {
    public static readonly watchlistlogtype none = new watchlistlogtype("");
    public static readonly watchlistlogtype block = new watchlistlogtype("block");
    public static readonly watchlistlogtype protect = new watchlistlogtype("protect");
    public static readonly watchlistlogtype rights = new watchlistlogtype("rights");
    public static readonly watchlistlogtype delete = new watchlistlogtype("delete");
    public static readonly watchlistlogtype upload = new watchlistlogtype("upload");
    public static readonly watchlistlogtype move = new watchlistlogtype("move");
    public static readonly watchlistlogtype import = new watchlistlogtype("import");
    public static readonly watchlistlogtype patrol = new watchlistlogtype("patrol");
    public static readonly watchlistlogtype merge = new watchlistlogtype("merge");
    public static readonly watchlistlogtype suppress = new watchlistlogtype("suppress");
    public static readonly watchlistlogtype review = new watchlistlogtype("review");
    public static readonly watchlistlogtype stable = new watchlistlogtype("stable");
    public static readonly watchlistlogtype spamblacklist = new watchlistlogtype("spamblacklist");
    public static readonly watchlistlogtype gblblock = new watchlistlogtype("gblblock");
    public static readonly watchlistlogtype renameuser = new watchlistlogtype("renameuser");
    public static readonly watchlistlogtype globalauth = new watchlistlogtype("globalauth");
    public static readonly watchlistlogtype gblrights = new watchlistlogtype("gblrights");
    public static readonly watchlistlogtype abusefilter = new watchlistlogtype("abusefilter");
    public static readonly watchlistlogtype articlefeedbackv5 = new watchlistlogtype("articlefeedbackv5");
    public static readonly watchlistlogtype pagetriage_curation = new watchlistlogtype("pagetriage-curation");
    public static readonly watchlistlogtype pagetriage_deletion = new watchlistlogtype("pagetriage-deletion");
    public static readonly watchlistlogtype institution = new watchlistlogtype("institution");
    public static readonly watchlistlogtype course = new watchlistlogtype("course");
    public static readonly watchlistlogtype student = new watchlistlogtype("student");
    public static readonly watchlistlogtype online = new watchlistlogtype("online");
    public static readonly watchlistlogtype campus = new watchlistlogtype("campus");
    public static readonly watchlistlogtype instructor = new watchlistlogtype("instructor");
    public static readonly watchlistlogtype thanks = new watchlistlogtype("thanks");
    public static readonly watchlistlogtype newusers = new watchlistlogtype("newusers");

    internal watchlistlogtype(string value)
      : base(value)
    {
    }

    public static bool operator ==(watchlistlogtype first, watchlistlogtype second)
    {
      return object.Equals((object) first, (object) second);
    }

    public static bool operator !=(watchlistlogtype first, watchlistlogtype second)
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
